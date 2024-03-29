﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Tutoring_Project
{
    class Question
    {
        /// <summary>
        /// https://github.com/kartheek619/Desktop-Quiz-Application
        /// This bit of code has been influnced and used from the github user kartheek619, however the code has been modified
        /// </summary>
        private string file;
            private string quesid;
            ArrayList list = new ArrayList();

            public ArrayList getQuestion(int id, string category)
            {

                try
                {
                    file =  "Test.xml";
                    quesid = id.ToString();
                    XElement root = XElement.Load(file);
                    IEnumerable<XElement> address =
                    from el in root.Elements("question")
                    where (string)el.Attribute("id") == quesid
                    select el;
                    foreach (XElement el in address)
                        foreach (XElement el1 in el.Elements())
                        {
                            list.Add(el1.Value);
                        }
                    return list;
                }
                catch (XmlException)
                {
                    list.Add("XML Exception has occured! Please contact administrator.");
                    return list;
                }
                catch (FileLoadException)
                {
                    list.Add("Not able to load data from backend! Please contact administrator.");
                    return list;
                }
                catch (FileNotFoundException)
                {
                    list.Add("Data file not found in backend! Please contact administrator.");
                    return list;
                }
                catch
                {
                    list.Add("Unknown error! Please contact administrator.");
                    return list;
                }

            }

        }
    }
