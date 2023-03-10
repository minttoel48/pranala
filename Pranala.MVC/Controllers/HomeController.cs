using Pranala.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pranala.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult GenerateSegitiga(string angka)
        {
           
            try
            {
                //check angka
                for(int i = 1; i <= angka.Length; i++)
                {
                    string checkNumber = angka.Substring(angka.Length - i, 1);

                    if (!Char.IsDigit(char.Parse(checkNumber)))
                    {
                        throw new Exception(checkNumber + " bukan angka!");
                    }
                }

                List<string> output = new List<string>();

                

                for(int i = 0; i < angka.Length; i++)
                {
                    string checkNumber = angka.Substring(angka.Length -( angka.Length - i), 1);

                    string nol = "";
                    for(int j = 0; j < i+1; j++)
                    {
                        nol = nol + "0";
                    }

                    output.Add(checkNumber + nol);
                }

                return Json(resultView.Create(true, output, string.Empty), JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {

                return Json(resultView.Create(false, null, ex.Message), JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult GenerateGanjil(string angka)
        {

            try
            {
                //check angka
                for (int i = 1; i <= angka.Length; i++)
                {
                    string checkNumber = angka.Substring(angka.Length - i, 1);

                    if (!Char.IsDigit(char.Parse(checkNumber)))
                    {
                        throw new Exception(checkNumber + " bukan angka!");
                    }
                }

                List<string> output = new List<string>();

                for (int i = 0; i < angka.Length; i++)
                {
                    string checkNumber = angka.Substring(angka.Length - (angka.Length - i), 1);

                    int intNumber = int.Parse(checkNumber);
                    
                    if(intNumber % 2 == 0)
                    {
                        output.Add(checkNumber + " bukan bilangan ganjil");
                    }
                    else
                    {
                        output.Add(checkNumber + " adalah bilangan ganjil");
                    }
                }

                return Json(resultView.Create(true, output, string.Empty), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(resultView.Create(false, null, ex.Message), JsonRequestBehavior.AllowGet);
            }
        }


        [HttpPost]
        public ActionResult GeneratePrima(string angka)
        {

            try
            {
                //check angka
                for (int i = 1; i <= angka.Length; i++)
                {
                    string checkNumber = angka.Substring(angka.Length - i, 1);

                    if (!Char.IsDigit(char.Parse(checkNumber)))
                    {
                        throw new Exception(checkNumber + " bukan angka!");
                    }
                }

                List<string> output = new List<string>();

                for (int i = 0; i < angka.Length; i++)
                {
                    string checkNumber = angka.Substring(angka.Length - (angka.Length - i), 1);

                    int intNumber = int.Parse(checkNumber);

                    bool isPrima = true;
                    if (intNumber >= 2)
                    {
                        for (int j = 2; j <= intNumber; j++)
                        {
                            for (int k = 2; k < j; k++)
                            {
                                if (j % k == 0)
                                {
                                    isPrima = false;
                                    break;
                                }
                                else
                                {
                                    isPrima = true;
                                }
                            }
                        }

                        if (isPrima)
                        {
                            output.Add(checkNumber + " bilangan prima");
                        }
                        else
                        {
                            output.Add(checkNumber + " bukan bilangan prima");
                        }
                    }
                    else
                    {
                        output.Add(checkNumber + " bilangan prima");
                    }
                }

                return Json(resultView.Create(true, output, string.Empty), JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                return Json(resultView.Create(false, null, ex.Message), JsonRequestBehavior.AllowGet);
            }
        }
    }
}