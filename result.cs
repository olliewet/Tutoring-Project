using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Tutoring_Project
{
    class result
    {
        private string file;
        private string Result = "";
        private string quesid;

        public string getResult(string option, int id, string category)
        {

            try
            {
                quesid = id.ToString();
                file = category + ".xml";
                XElement root = XElement.Load(file);
                IEnumerable<XElement> address =
                from el in root.Elements("question")
                where (string)el.Attribute("id") == quesid
                select el;
                foreach (XElement el in address)
                    foreach (XElement el1 in el.Elements())
                    {
                        if (el1.Name == "correct")
                        {
                            if (el1.Value == option)
                            {
                                Result = "CORRECT";
                            }
                            else
                            {
                                Result = "WRONG";
                            }
                        }
                    }
                return Result;
            }
            catch (XmlException)
            {
                return "XML Exception has occured! Please contact administrator.";

            }
            catch (FileLoadException)
            {
                return "Not able to load data from backend! Please contact administrator.";
            }
            catch (FileNotFoundException)
            {
                return "Data file not found in backend! Please contact administrator.";
            }
            catch
            {
                return "Unknown error! Please contact administrator.";
            }

        }
    }
}
