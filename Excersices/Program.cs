using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Workflow

            //var workflow = new ClassLibrary.Workflow(new List<ClassLibrary.IActivity>());
            //workflow.Add(new ClassLibrary.ActivityUploadVideo());
            //workflow.Add(new ClassLibrary.ActivityEncodeVideo());
            //workflow.Add(new ClassLibrary.ActivityNotify());
            //workflow.Add(new ClassLibrary.ActivityChangeStatus());
            //var workflowEngine = new ClassLibrary.WorkflowEngine();
            //workflowEngine.Run(workflow);
            //Console.ReadKey();

            //Connection
            //ClassLibrary.DbConnection dbConnection = new ClassLibrary.OracleConnection("Connection string", new TimeSpan(0, 5, 0));
            //ClassLibrary.DbCommand dbCommand = new ClassLibrary.DbCommand(dbConnection, "SELECT * FROM CLIENT;");
            //dbCommand.Execute();

            //Console.ReadKey();

            // Stack

            var stack = new ClassLibrary.Stack();
            stack.Push("Hello World");
            stack.Push(1);
            stack.Push(15.69);
            stack.Push(true);
            stack.Push('e');
            stack.PrintAll();
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.ReadKey();


            //Stack Overflow post
            //ClassLibrary.Post post = new ClassLibrary.Post("My New Post", "This is just a test to see how to post");
            //var upvotes = 80;
            //var downvotes = 20;
            //for (int i = 0; i < upvotes; i++)
            //{
            //    post.UpVote();
            //}
            //for (int i = 0; i < downvotes; i++)
            //{
            //    post.DownVote();
            //}
            //Console.WriteLine("Title: " + post._Title);
            //Console.WriteLine("Description: " + post._Description);
            //Console.WriteLine("Creation date: " + post._CreationDate);
            //Console.WriteLine("Upvotes: " + post.UpVotes);
            //Console.WriteLine("Downvotes: " + post.DownVotes);
            //Console.WriteLine("Votes: " + post.Votes);
            //Console.ReadKey();

        }
    }
}
