﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using LTCDashboard.Data;
using LTCDataManager.Email;
using LTCDataManager.NewsLetter;
using LTCDataManager.Office;
using LTCDataManager.Subscriber;
using LTCDataModel.NewsLetter;
using LTCDataModel.Office;
using LTCDataModel.Subscriber;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using LTCDashboard.Controllers;
using LTCDataModel.Newsletter;
using LTCDataModel.Enums;
 
namespace LTC_Dashboard.Controllers
{
    [Authorize]
    public class NewsletterController : NewsletterBaseController
    {
        private readonly IOptions<EmailManager.ElasticEmail> _email;
        private readonly UserManager<ApplicationUser> _userManager;
        // GET: Newsletters
        public ActionResult Index()
        {


            @ViewBag.OfficeName = OfficeName;
            gNewsLetterManager.CreateDefaultParadigmNewsletter(OfficeSequence);
            return View();
        }

        private IHttpContextAccessor _accessor;

        public NewsletterController(IHostingEnvironment hostingEnvironment, IHttpContextAccessor accessor, IOptions<EmailManager.ElasticEmail> email) : base(hostingEnvironment)

        {
            _accessor = accessor;
            _email = email;


        }
        public JsonResult GetTemplateTypes()
        {
            var objResult = new List<gTemplateTypeModel>();

            try
            {
                objResult = gNewsLetterManager.GetTemplateTypes(OfficeSequence);
                return Json(objResult);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        public JsonResult GetArticleTypes()
        {
            var objResult = new List<gArticleCategories>();

            try
            {
                objResult = gNewsLetterManager.GetArticleCategories();
                return Json(objResult);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        [HttpPost]
        public JsonResult UpdateArticle([FromBody]gArticleModelTest model)
        {
            try
            {

                model.ContentImage = model.ContentImage.Replace("data:image/png;base64,", "");
                gNewsLetterManager.UpdateArticle(model);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        [HttpPost]
        public JsonResult UpdateNewsletter([FromBody]gLetterModelTest model)
        {
            try
            {

                model.ContentImage = model.ContentImage.Replace("data:image/png;base64,", "");
                gNewsLetterManager.UpdateLetter(model);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        public JsonResult GetArticles()
        {
            var objResult = new List<gArticleViewModel>();

            try
            {
                objResult = gNewsLetterManager.GetArticles();
                //foreach (var item in objResult)
                //{
                //    item.ContentWithDefaultStyle = item.ContentWithDefaultStyle.Replace("http://ltcdashboard.azurewebsites.net/", "https://localhost:44380/");
                //}

                return Json(objResult);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }


        public JsonResult GetShellTemplates()
        {
            var objResult = new List<gGetPreDefinedTemplateModel>();

            try
            {
                objResult = gNewsLetterManager.GetPreDefinedTemplates();
                return Json(objResult);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }

        public JsonResult GetSystemTemplates()
        {
            var objResult = new List<gGetPreDefinedTemplateModel>();

            try
            {
                //CurrentOfficeId
                objResult = gNewsLetterManager.GetPreDefinedTemplates();
                return Json(objResult);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }

        public JsonResult GetUserDefinedTemplates()
        {
            var objResult = new List<gGetUserDefinedTemplateModel>();

            try
            {

                objResult = gNewsLetterManager.GetUserDefinedTemplates(OfficeSequence);
              
                return Json(objResult);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        [HttpPost]
        public JsonResult moveArticle([FromBody] MoveArticleModel model)
        {
            try
            {

                gNewsLetterManager.MoveArticle(model.CategoryId, model.ArticleId);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }

        public JsonResult RemoveSelectedUserDefinedTemplate([FromBody] NewsletterViewDeleteModel model)
        {
            try
            {

                gNewsLetterManager.DeleteUserDefinedTemplate(model.tempId);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }

        public JsonResult LoadServerTime()
        {
            try
            {
                var timeUtc = DateTime.UtcNow;
                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(timeUtc, easternZone);
                var res = easternTime.Month.ToString() + "/" + easternTime.Day.ToString() + "/" + easternTime.Year.ToString() + " " + easternTime.TimeOfDay.ToString();
                return Json(res);
                // return Json(easternTime.ToString());
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        public class DateSetting
        {
            public static DateTime ValidDate
            {
                get
                {
                    return new DateTime(1990, 1, 1);
                }
            }
        }
        [HttpPost]
        public async System.Threading.Tasks.Task<JsonResult> SendNewsletterAsync([FromBody]LTCDataModel.Newsletter.NewsletterViewModel model)
        {
            try
            {
                TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, easternZone);
                int status = 2;
                if ((model.ScheduledDateTime.Date <= now.Date) && (model.ScheduledDateTime.TimeOfDay <= now.TimeOfDay))
                {
                    model.ScheduledDateTime = now;
                    status = 2;

                }
                else if (model.ScheduledDateTime > now)
                {
                    status = 1;
                }

                int Hour = model.ScheduledDateTime.Hour;
                if (Hour <= 0)
                {
                    Hour = 12;
                }

                var Template = gNewsLetterManager.GetUserDefinedTemplate(model.TemplateId);
                if (Template == null)
                {
                    return Json(null);
                }

                var office = gOfficeManager.GetOfficeName(OfficeSequence);
                var patient = new gPatientOfficeInfo();
                patient.AppointmentDate = model.ScheduledDateTime.Date.ToString("yyyy-MM-dd");
                patient.AppointmentTime = model.ScheduledDateTime.ToString("HH:mm");

                var emailSent = false;
                if (model.SendToSubscribers)
                {
                    SubscriberFilterParams parm = new SubscriberFilterParams() { Office_Sequence = OfficeSequence.ToString() };
                    var subscribers = gSubscriber.GetSubscribers(parm);

                    foreach (var subscriber in subscribers)
                    {
                        string msgID = null;
                        String SubScriberName = subscriber.Salutation + " " + subscriber.FirstName + " " + subscriber.LastName;
                        string familyList = subscriber.Salutation + "," + subscriber.LastName + "," + subscriber.FirstName;
                        patient.FirstName = subscriber.FirstName;
                        patient.LastName = subscriber.LastName;
                        patient.Name = SubScriberName;
                        patient.Salutation = subscriber.Salutation;
                        var template = EmailManager.StringExtention.ClearTemplate(office, Template, patient, familyList);
                        if (status == 2)
                        {

                            msgID = EmailManager.Send(Template.TemplateTitle,
                                new[]
                                {
                                    subscriber.EmailAddress
                                }, template, new EmailManager.ElasticEmail { Email = _email.Value.Email, FromName = _email.Value.FromName, APIKey = _email.Value.APIKey });
                            emailSent = true;
                        }

                        gPatientCallList obj = new gPatientCallList()
                        {
                            Office_Sequence = OfficeSequence,
                            EmailContent = template,
                            EmailSubject = Template.TemplateTitle,
                            Email = subscriber.EmailAddress,
                            PatientName = SubScriberName,
                            NewsletterID = model.TemplateId,
                            SubscriberID = subscriber.Id,
                            DateToSendEmail = model.ScheduledDateTime,
                            // EmailSentOnDate = DateSetting.ValidDate,
                            Account = UserId,
                            Status = status,
                            EmailSent = emailSent,
                            MessageID = msgID
                        };

                        obj.MessageID = msgID;
                        gNewsLetterManager.SendSubscriber(obj);


                    }

                }
                else
                {
                    SubscriberFilterParams parm = new SubscriberFilterParams() { Office_Sequence = OfficeSequence.ToString() };

                    var subscriber = gSubscriber.GetByEmail(model.Email);
                    if (subscriber != null)
                    {
                        string msgID = null;
                        string familyList = subscriber.Salutation + "," + subscriber.LastName + "," + subscriber.FirstName;
                        patient = new gPatientOfficeInfo();
                        //if (patient == null)
                        //{
                        //    patient = new gPatientOfficeInfo();
                        patient.FirstName = subscriber.FirstName;
                        patient.LastName = subscriber.LastName;
                        patient.Name = model.Email;

                        //}
                        patient.AppointmentDate = model.ScheduledDateTime.Date.ToString("yyyy-MM-dd");
                        patient.AppointmentTime = model.ScheduledDateTime.ToString("HH:mm");
                        var template = EmailManager.StringExtention.ClearTemplate(office, Template, patient, familyList);
                        if (status == 2)
                        {
                            msgID = EmailManager.Send(Template.TemplateTitle,
                                 new[]
                                 {
                                model.Email
                                 }, template,
                                 new EmailManager.ElasticEmail
                                 {
                                     Email = _email.Value.Email,
                                     FromName = _email.Value.FromName,
                                     APIKey = _email.Value.APIKey
                                 });
                            emailSent = true;
                        }
                        gPatientCallList obj = new gPatientCallList()
                        {
                            Office_Sequence = OfficeSequence,
                            EmailContent = template,
                            EmailSubject = Template.TemplateTitle,
                            Email = model.Email,
                            PatientName = model.Email,
                            NewsletterID = model.TemplateId,
                            SubscriberID = subscriber.Id,
                            DateToSendEmail = model.ScheduledDateTime,
                            Account = UserId,
                            Status = status,
                            EmailSent = emailSent
                        };
                        if (emailSent)
                            obj.EmailSentOnDate = model.ScheduledDateTime;


                        obj.MessageID = msgID;
                        gNewsLetterManager.SendSubscriber(obj);

                    }
                    else
                    {
                        return Json(false);
                    }


                }


                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }

        [HttpPost]
        public JsonResult MakeDefault([FromBody]gMakeDefault model)
        {
            try
            {
                //   var user = (CustomMembershipUser)Membership.GetUser(User.Identity00-.Name, true);
                gNewsLetterManager.MakeDefault(model.LetterID, model.IsDefault);
                return Json(gNewsLetterManager.MakeDefault(model.LetterID, model.IsDefault));
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        [HttpPost]
        public JsonResult CopySystemTemplate([FromBody]gCopyTemplate model)
        {
            try
            {
                //   var user = (CustomMembershipUser)Membership.GetUser(User.Identity00-.Name, true);
                gNewsLetterManager.CopySystemTemplate(model.TemplateId, model.Title, OfficeSequence);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        [HttpPost]
        public JsonResult CopyArticle([FromBody]gArticleTemplate model)
        {
            try
            {
                byte[] contentImage = null;
                if (model.ContentImageString != "data:,")
                {
                    model.ContentImageString = model.ContentImageString.Replace("data:image/png;base64,", "");
                    contentImage = Convert.FromBase64String(model.ContentImageString);
                }
                gNewsLetterManager.CopyArticle(model.TemplateId, model.ArticleId, model.Title, OfficeSequence, model.Content, contentImage);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }

        [HttpPost]
        public JsonResult DeleteSelected([FromBody]gSelectedIds model)
        {
            try
            {
                gNewsLetterManager.DeleteMultiple(model.SelectedIds);
                return Json(true);
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }
        public JsonResult SaveNewsletterEditor([FromBody] gSaveUserTemplateModel model)
        {
            try
            {
              
                if (model.ContentImageString != "data:,")
                {
                    model.ContentImageString = model.ContentImageString.Replace("data:image/png;base64,", "");
                    byte[] byteArray = Convert.FromBase64String(model.ContentImageString);
                    model.ContentImage = byteArray;
                }
                model.Office_Sequence = OfficeSequence;
                gSaveUserTemplate obj = new gSaveUserTemplate()
                {
                    ContentImage = model.ContentImage,
                    EmbeddedNewsletter = model.EmbeddedNewsletter,
                    IsDefault = model.IsDefault,
                    IsParadigmNewsletter = model.IsParadigmNewsletter,
                    LetterID = model.LetterID,
                    MainBodymarkup = model.MainBodymarkup,
                    ModificationDate = model.ModificationDate,
                    Office_Sequence = model.Office_Sequence,
                    TemplateSourceMarkup = model.TemplateSourceMarkup,
                    TemplateTitle = model.TemplateTitle,
                    ThumbnailPath = model.ThumbnailPath,
                    TypeID = model.TypeID,
                    CategoryID = model.CategoryID

                };

                return Json(gNewsLetterManager.SaveUserNewsTemplate(obj));
            }
            catch (Exception ex)
            {
                return Json(null);
            }
        }

        #region Home
        public ActionResult Home()
        {
            @ViewBag.OfficeName = OfficeName;
            gNewsLetterManager.CreateDefaultParadigmNewsletter(OfficeSequence);


            return View();
        }
        public ActionResult GetScheduledNewsLetterStatistics(string category, string period)
        {
            ScheduledNewsLetterStatisticsViewModel result = new ScheduledNewsLetterStatisticsViewModel();
            try
            {
                int intCategory = 3;
                if (category == "Sent")
                {
                    intCategory = 2;
                }
                else if (category == "Scheduled")
                {
                    intCategory = 1;
                }

                result.ScheduledNewsLetter = gNewsLetterManager.GetDashboard(intCategory, period, OfficeSequence);
                foreach (var item in result.ScheduledNewsLetter)
                {
                    item.SentTimeString = item.SentTime.ToString(@"yyyy-MM-dd hh:mm tt", new CultureInfo("en-US"));
                }

                result.ScheduledNewsLetter = result.ScheduledNewsLetter.OrderByDescending(c => c.SentTime).ToList();
                result.Scheduled = result.ScheduledNewsLetter.Count(s => s.Status == ScheduledNewsLetterStatus.Scheduled);
                result.Sent = result.ScheduledNewsLetter.Count(s => s.Status == ScheduledNewsLetterStatus.Sent);
            }
            catch (Exception ex)
            {
                // log
            }
            return PartialView("_ScheduledNewsLettersStatistics", result);
        }

        #endregion
    }
}