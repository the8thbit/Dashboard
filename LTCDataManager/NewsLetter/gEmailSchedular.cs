﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using ElasticEmailClient;
using LTCDataManager.Email;
using LTCDataManager.NewsLetter;
using LTCDataManager.Office;
using LTCDataModel.Office;
 
 

namespace DentalDataManager.DataManager.NewsLetter
{
    public class gEmailSchedular
    {
        public static void GetTemplates(string SenderEmail, string ApiKey, string FromName)
        {
            var emailList = gNewsLetterManager.GetPatientCallListForEmail();
            foreach (var newsletter in emailList)
            {
                var template = gNewsLetterManager.GetUserDefinedTemplate(newsletter.NewsletterId);
                if (template != null)
                {
                    var office = gOfficeManager.GetOfficeName(newsletter.Office_Number);
                    var patient = gOfficeManager.GetPatientInfo(newsletter.Email) ?? new gPatientOfficeInfo
                    {
                        FirstName = newsletter.PatientName,
                        LastName = newsletter.PatientName,
                        Name = newsletter.PatientName
                    };
                    var body = EmailManager.StringExtention.ClearTemplate(office, template, patient);

                    EmailManager.Send(template.TemplateTitle,
                        new[]
                        {
                            newsletter.Email
                        }, body, new EmailManager.ElasticEmail{ Email = SenderEmail, FromName = FromName, APIKey = ApiKey});

                    gNewsLetterManager.UpdatePatientCallList(newsletter.ID);
                }

            }
        }
    }
}
