using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

namespace Project_APD.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            /*Variables et Objets*/

            string select;  //Sélection de la raison du contact (Renseignement, Devis, Prise de RDV)
            string name;    //Nom de la personne
            string mailExp; //Mail Expéditeur
            string subj;    //Sujet du Mail
            string msg;     //Corps du mail

            string targetAdress = "stevengrey45@gmail.com"; //Adresse Destinataire


            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.orange.fr",
                Port = 587,                
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("legende_de_celine@hotmail.fr", "Fairytailsteven6"),
                EnableSsl = true
            };

            /*Fin Variables*/

            /*Récupération des données saisies par l'utilisateur*/
            select = Request.Form["informations2"];
            name = Request.Form["name"];
            mailExp = Request.Form["email"];
            subj = Request.Form["subject"];
            msg = Request.Form["Message"];

            /*Création de l'e-mail*/

            //MailMessage email = new MailMessage();

            MailMessage email = new MailMessage(mailExp, targetAdress)
            {
                Subject = select + " : " + subj,
                Body = msg + "\n\n" + name
            };
            /*
            // Expéditeur
            email.From = new MailAddress(mailExp);

            // Destinataire
            email.To.Add(new MailAddress("stevengrey45@gmail.com"));

            // Sujet
            email.Subject = select + " : " + subj;

            // Corps
            email.Body = msg;
            */

            /*Envoie du Mail*/
            smtp.Send(email);

            return View("About");
        }
    }
}