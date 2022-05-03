using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAPP
{
    public static class ExtensionPerson
    {
        public static string CompletaName(this Person person)
        {
            return $"{person.SurnaName} {person.Name}";
        }
    }
}
