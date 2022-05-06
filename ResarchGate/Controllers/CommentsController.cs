using ResarchGate.Models;
using ResarchGate.ViewModels;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ResarchGate.Controllers
{
    public class CommentsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult details(int id)
        {
            var db = new dbreserchgateEntities();
            var Research = db.tbl_paper.FirstOrDefault(x => x.p_id == id);

            return View(Research);


        }
        [HttpPost]
        public JsonResult LeaveComment(CommentViewModel model)
        {
            JsonResult result = new JsonResult();
            try
            {
                var comment = new tbl_comments();
                comment.c_text = model.CommentText;
                comment.PaperId = model.ResearchId;
                comment.c_id = model.CommentId;
                comment.UserId = Int16.Parse(User.Identity.GetUserId());
                comment.c_timestamp = DateTime.Now;
                result.Data = new { Success = SaveComment(comment) };
            }
            catch (Exception ex)
            {
                result.Data = new { Success = false, Message = ex.Message };
            }



            return result;


        }
        public bool SaveComment(tbl_comments comment)
        {
            var db = new dbreserchgateEntities();


            db.tbl_comments.Add(comment);
            return db.SaveChanges() > 0;




        }
    }
}