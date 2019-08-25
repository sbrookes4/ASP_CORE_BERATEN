//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using BeratenHealthcareModels;

//namespace BeratenHealthcareDataAccessLib
//{
//    internal class BeratenInitializer : CreateDatabaseIfNotExists<EntityModel>
//    {
//        protected override void Seed(EntityModel context)
//        {            
//            RunSqlScripts(context);           
//            base.Seed(context);
//        }

//        private void RunSqlScripts(EntityModel context)
//        {
//            var path = Assembly.GetExecutingAssembly().Location;
//            var di = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(path),"Misc\\"));
//            var scripts = di.EnumerateFiles().Where(f => f.Extension.Equals(".sql", StringComparison.InvariantCultureIgnoreCase));
//            foreach(var s in scripts)
//            context.Database.ExecuteSqlCommand(new StreamReader(File.OpenRead(s.FullName)).ReadToEnd());
//        }        
//    }
//}