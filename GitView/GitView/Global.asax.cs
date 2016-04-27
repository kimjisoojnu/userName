using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;


using UserNameClass;

namespace GitView
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //테스트를 위해 작업을 진행합니다.

            UserNameClass.Class1 obj = new Class1();

            string str = obj.UserMame();
        }
    }
}
