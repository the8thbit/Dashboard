﻿
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LTCDataManager.DataAccess;
using LTCDataModel.PetaPoco;
using LTCDataModel.Subscriber;

namespace LTCDataManager.Subscriber
{
    public static class gSubscriber
    {
       
        public static void Add(gSaveSubscriber objSubscribers)
        {
            try
            {
                using (var db = new Database(DbConfiguration.LtcNewsletter))
                {
                    db.Save(objSubscribers);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static void Update(gSaveSubscriber objSubscribers)
        {
            try
            {

                using (var db = new Database(DbConfiguration.LtcNewsletter))
                {
                    gSaveSubscriber found = db
                        .Fetch<gSaveSubscriber>($"select * from subscribers where Id={objSubscribers.Id}")
                        .FirstOrDefault();
                    if (found != null)
                    {
                        objSubscribers.SubscriptionStatus = found.SubscriptionStatus;
                        db.Update(objSubscribers, objSubscribers.Id);
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static List<gSaveSubscriber> GetAll(SubscriberFilterParams parameters)
        {
            try
            {
                var db = new Database(DbConfiguration.LtcNewsletter);
                var res = db.Fetch<gSaveSubscriber>($"SELECT * FROM subscribers where DoctorID = " + parameters.DoctorID).ToList();
               
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<gSaveSubscriber> GetSubscribers(SubscriberFilterParams parameters)
        {
            try
            {
                var db = new Database(DbConfiguration.LtcNewsletter);
                var res = db.Fetch<gSaveSubscriber>($"SELECT * FROM subscribers where SubscriptionStatus = 1 AND DoctorID = " + parameters.DoctorID).ToList();
               
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private static SubscriptionViewModel DataRowToBusiness(DataRow row)
        {
            SubscriptionViewModel objTempViewModel = null;
            //objTempViewModel = new SubscriptionViewModel();
            //objTempViewModel.ID = row["ID"].ConvertToType<int>();
            //objTempViewModel.CreatedOn = row["CreatedOn"].ConvertToType<DateTime>();
            //objTempViewModel.FirstName = row["FirstName"].ConvertToType<string>();
            //objTempViewModel.Email = row["EmailAddress"].ConvertToType<string>();
            //objTempViewModel.Status = row["SubscriptionStatus"].ConvertToType<bool>() ? SubscriptionStatus.Subscribed : SubscriptionStatus.UnSubscribed;
            //objTempViewModel.LastName = row["LastName"].ConvertToType<string>();
            //objTempViewModel.LastSubscriptionStatusUpdated = row["LastSubscriptionStatusUpdated"].ConvertToType<DateTime>();
            //objTempViewModel.SubscribedDate = objTempViewModel.LastSubscriptionStatusUpdated;

            //if (objTempViewModel.Status == SubscriptionStatus.UnSubscribed)
            //    objTempViewModel.UnSubscribedDate = objTempViewModel.LastSubscriptionStatusUpdated;

            return objTempViewModel;
        }

        public static SubscriptionViewModel GetById(int Id)
        {
            try
            {
                var db = new Database(DbConfiguration.LtcNewsletter);
                return db.Fetch<SubscriptionViewModel>($"SELECT * FROM subscribers where Id = " + Id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Delete(int Id, bool deleteAll)
        {
            try
            {
                using (var db = new Database(DbConfiguration.LtcNewsletter))
                {
                    if (deleteAll)
                        db.Execute($"Delete FROM subscribers where DoctorID = " + Id);
                    else
                        db.Delete("subscribers", "Id", new gSaveSubscriber { Id = Id });

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





        public static int ToggleStatus(int Id, string doctorID)
        {
            try
            {
                SubscriptionViewModel objSubscription = GetById(Id);
                int nextStatus = objSubscription.SubscriptionStatus == SubscriptionStatus.Subscribed ? 0 : 1;
                var db = new Database(DbConfiguration.LtcNewsletter);
                return db.Execute($"UPDATE subscribers  SET SubscriptionStatus = {nextStatus} , LastSubscriptionStatusUpdated = '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}' WHERE Id= {Id}; ");


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
