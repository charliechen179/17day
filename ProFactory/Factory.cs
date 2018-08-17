using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ProOperation;

namespace ProFactory
{
   public class Factory
    {
        public static Operation GetOper(string type,int n1,int n2)
        {
            Operation oper = null;

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Plug");

         string[] files=   Directory.GetFiles(path);

            foreach (var item in files)
            {
                Assembly ass = Assembly.LoadFile(item);
               Type[] types= ass.GetExportedTypes();
                foreach (var t in types)
                {
                    if (t.IsSubclassOf(typeof(Operation))&& !t.IsAbstract )
                    {
                        oper = (Operation)Activator.CreateInstance(t, n1, n2);
                    }
                }

                if (type==oper.Type)
                {
                    break;
                }
                else
                {
                    oper = null;
                }
            }

            

            return oper;
        }
    }
}
