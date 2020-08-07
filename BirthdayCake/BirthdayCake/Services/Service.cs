using BirthdayCake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace BirthdayCake.Services
{
    class Service
    {

        /// <summary>
        /// Checks if there is a username in the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public tblGuest GetUsername(string username)
        {
            try
            {
                using (BirthdayCakeEntities context = new BirthdayCakeEntities())
                {
                    tblGuest user = (from e in context.tblGuests where e.GuestUsername.Equals(username) select e).First();
                    
                    return user;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        /// <summary>
        /// Checks if there is a phoneNumber in the database
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public tblGuest GetPhoneNumber(string phoneNumber)
        {
            try
            {
                using (BirthdayCakeEntities context = new BirthdayCakeEntities())
                {
                    tblGuest user = (from e in context.tblGuests where e.PhoneNumber.Equals(phoneNumber) select e).First();

                    return user;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        /// <summary>
        /// Method for adding new Guest
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public tblGuest AddUser(tblGuest user)
        {
            try
            {

                using (BirthdayCakeEntities context = new BirthdayCakeEntities())
                {
                    if (user.GuestID == 0)
                    {
                        tblGuest newUser = new tblGuest
                        {
                            GuestID = user.GuestID,
                            GuestUsername = user.GuestUsername,
                            GuestPassword = user.GuestPassword,
                            GuestNameSurname = user.GuestNameSurname,
                            GuestAddress = user.GuestAddress,
                            PhoneNumber = user.PhoneNumber,
                            NumberOrder = user.NumberOrder
                        };

                        context.tblGuests.Add(newUser);
                        context.SaveChanges();
                        user.GuestID = newUser.GuestID;
                        return user;
                    }
                    else
                    {
                        tblGuest userToEdit = (from r in context.tblGuests where r.GuestID == user.GuestID select r).First();

                        userToEdit.GuestUsername = user.GuestUsername;
                        userToEdit.GuestPassword = user.GuestPassword;
                        userToEdit.GuestNameSurname = user.GuestNameSurname;
                        userToEdit.GuestAddress = user.GuestAddress;
                        userToEdit.PhoneNumber = user.PhoneNumber;
                        userToEdit.NumberOrder = user.NumberOrder;
                        context.SaveChanges();
                        return user;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nešto je pošlo po zlu prilikom registracije", "Greška");
                System.Diagnostics.Debug.WriteLine("Exception: " + ex.Message.ToString());
                return null;
            }
        }

        /// <summary>
        /// Return username and password on database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public tblGuest GetUsernamePassword(string username, string password)
        {
            try
            {
                using (BirthdayCakeEntities context = new BirthdayCakeEntities())
                {
                    tblGuest user = (from e in context.tblGuests where e.GuestUsername.Equals(username) where e.GuestPassword.Equals(password) select e).First();

                    return user;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }
    }
}
