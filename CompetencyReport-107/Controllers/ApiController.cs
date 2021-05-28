using System;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace taskManager.Controllers
{
    public class ApiController : Controller
    {
        static List<Task> DB;
        static int count;

        public ApiController(){

         if(DB== null)   
        { 
            DB = new List<Task>();
            count =1;
        }
    }
        public IActionResult Test()
        {
            return Content("Hello from API");
        }

        [HttpGet]
        public IActionResult getTasks()
        {
             Console.WriteLine("Get task");
            return Json(DB);
        }
        [HttpPost]
        public IActionResult saveTask([FromBody] Task task)
        {
            Console.WriteLine("Saving task"+task.Title);
            task.Id=count++;
            //save it on DB
            DB.Add(task);
            
            return Json(task);
        }

        [HttpDelete]
        public IActionResult deleteTasks(int id){
            
            
            //find the task with the id
            Task t = DB.First(t => t.Id == id);
            //remove that task
            DB.Remove(t);
            return Ok();
        }
        [HttpPatch]
        public IActionResult MarkDone(int id)
        {
            //finde the task
            Task t = DB.First(t => t.Id == id);
            //change the status
            t.Status=2;
            return Json(t);
        }

        
    }
}