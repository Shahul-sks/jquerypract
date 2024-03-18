using jquerypract.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace jquerypract.Controllers
{
    public class KendoController : Controller
    {
        private readonly StateContext stateContext;

        private readonly ILogger<KendoController> _logger;

        public KendoController(StateContext context, ILogger<KendoController> logger)
        {
            stateContext = context;
            _logger = logger;
        }


        //inserting username and password to the table
        //[HttpPost]
        //public IActionResult Register([FromBody] login login)
        //{
        //    try
        //    {
        //        if (login == null)
        //        {
        //            return BadRequest(new { Success = false, Message = "Invalid user data." });
        //        }

        //        login newUser = new login
        //        {
        //            mailid = login.mailid,
        //            password = login.password
        //        };

        //        stateContext.logins.Add(newUser);
        //        stateContext.SaveChanges();

        //        return Ok(new { Success = true, Message = "User registered successfully." });
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error registering user.");
        //        return StatusCode(500, new { Success = false, Message = "Internal server error." });
        //    }
        //}

        [HttpPost]
        public IActionResult Login(string mailid, string password)
        {
            if (string.IsNullOrEmpty(mailid) || string.IsNullOrEmpty(password))
            {
                ViewBag.LoginErrorMessage = "Email and password are required.";
                return View("Login");
            }

            var usr = stateContext.signUps.FirstOrDefault(x => x.email == mailid && x.password == password);
            if (usr != null)
            {
                return RedirectToAction("Home","Home");
            }
            else
            {
                ViewBag.LoginErrorMessage = "Invalid Email or Password";
                
                return View("Login","Home");
                

            }
        }

        [HttpPost]
        public IActionResult signup([FromBody] SignUp signUp)
        {
            try
            {
                if (signUp == null)
                {
                    return BadRequest(new { Success = false, Message = "Invalid user data." });
                }
                SignUp newUser = new SignUp
                {
                    name = signUp.name,
                    state = signUp.state,
                    gender = signUp.gender,
                    mobile = signUp.mobile,
                    email = signUp.email,
                    password = signUp.password,
                    confirmpass = signUp.confirmpass,
                    dob = signUp.dob,
                    address = signUp.address
                };
                stateContext.signUps.Add(newUser);
                stateContext.SaveChanges();
                return Ok(new { Success = true, Message = "User registered successfully." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error registering user.");
                return StatusCode(500, new { Success = false, Message = "Internal server error." });
            }
        }







        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }

        //public KendoController(StateContext state)
        //{
        //    this.stateContext = state;
        //}

        public ActionResult GetData()
        {
            var states = stateContext.states.ToList();
            return Json(states);
        }
        public ActionResult GetData2()
        {
            var city = stateContext.cities.ToList();
            return Json(city);
        }

        public ActionResult Createdrop(city city)
        {

            stateContext.cities.Add(city);
            stateContext.SaveChanges();

            return Json(city);
        }



    }


 }
