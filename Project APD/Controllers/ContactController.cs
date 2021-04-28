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
            /*Variables*/
            
            string select;  //Sélection de la raison du contact (Renseignement, Devis, Prise de RDV)
            string name;    //Nom de la personne
            string mailExp; //Mail Expéditeur
            string subj;    //Sujet du Mail
            string msg;     //Corps du mail
            

            /*Fin Variables*/

            /*Récupération des variables*/
            select = Request.Form["informations2"];
            name = Request.Form["name"];
            mailExp = Request.Form["email"];
            subj = Request.Form["subject"];

            /*Création de l'e-mail*/

            MailMessage email = new MailMessage();

            // Expéditeur
            email.From = new MailAddress(mailExp);

            // Destinataire
            email.To.Add(new MailAddress("stevengrey45@gmail.com"));

            // Sujet
            email.Subject = select + " : " + subj;

            // Corps
            email.Body = "Contenu de l'email au format texte";

                
            /*Envoie du Mail*/
            SmtpClient smtp = new SmtpClient();
            smtp.Send(email);

            return View("About");
        }
    }
}