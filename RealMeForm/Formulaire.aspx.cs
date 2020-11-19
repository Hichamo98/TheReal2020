using RealMeForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheRealMe.Controller;

namespace RealMeForm
{
    public partial class Formulaire : System.Web.UI.Page
    {
        PersonManager manager;
        DocumentDBService service;
        static Evaluation eV=new Evaluation();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //bool ok;
           
            idEmetteur.Text = Request.Params["id"];
            
            mirror.Text = Request.Params["mirror"];
            
            group.Text = Request.Params["group"];
            
            critere.Text = Request.Params["critere"];
             
 
           /* Mutex mt = new Mutex(true, "binjoury",out ok);
            if(ok)
            {
                
                mt.ReleaseMutex();
            }*/


        }

       

        protected void Button2_Click(object sender, EventArgs e) 
        {
 
          
            service = new DocumentDBService();
            manager = new PersonManager(service);
            int a = Int16.Parse(note.Text);
            eV = new Evaluation(idEmetteur.Text, firstName.Text, lastName.Text, mirror.Text, group.Text, critere.Text, a); ;
            manager.SavePersonneAsync(eV, true);
            Response.Write("<script> alert('Your evaluation has been saved');</script>");
            firstName.Text = "";
            lastName.Text = "";
            note.Text = "";
            idEmetteur.Text = "";
            mirror.Text = "";
            group.Text = "";
            critere.Text = "";

        }
    }
}