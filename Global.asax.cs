using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;

namespace _51.EntityFramework.Code.Approach
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

            // Τι θα κάνει το EntityFramework όταν το Model αλλάξει.
            // Θα φτιάξω την κλάση Database και αυτή η κλάση είναι στο using System.Data.Entity;
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EmployeeDBContext>())

            // Φτιάχνω νέο Instance της κλάσης EmployeeDBContextSeeder
            Database.SetInitializer(new EmployeeDBContextSeeder());
        }
    }
}