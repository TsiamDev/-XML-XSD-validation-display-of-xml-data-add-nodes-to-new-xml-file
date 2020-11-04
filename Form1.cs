using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace Ex12
{
    public partial class Form1 : Form
    {
        string xmlPath;
        string xsdPath;

        static bool hasErrorOccured;

        static ValidationEventHandler eventHandler;

        static DataTable dt;

        List<TableElements> tableElements;

        class TableElements
        {
            public List<string> day;
            public string lesson;
            public string prof;

            public TableElements()
            {
                day = new List<string>();
            }
        }

        public Form1()
        {
            InitializeComponent();

            xmlPath = null;
            xsdPath = null;

            hasErrorOccured = false;
            eventHandler = new ValidationEventHandler(ValidationEventHandler);
        }

        private void loadFilesButton_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void LoadFiles()
        {
            //Open XML file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Get the path of specified file
                    xmlPath = openFileDialog.FileName;
                    xmlLabel.Text = "XML File Opened: " + xmlPath;

                    //If successfully opened XML file, open XSD File
                    using (OpenFileDialog openFileDialog2 = new OpenFileDialog())
                    {
                        openFileDialog2.InitialDirectory = "c:\\";
                        openFileDialog2.Filter = "XSD Files (*.xsd)|*.xsd";
                        openFileDialog2.FilterIndex = 2;
                        openFileDialog2.RestoreDirectory = true;

                        DialogResult result2 = openFileDialog2.ShowDialog();
                        if (result2 == DialogResult.OK)
                        {
                            //Get the path of specified file
                            xsdPath = openFileDialog2.FileName;
                            xsdLabel.Text = "XSD File Opened: " + xsdPath;
                        }
                    }
                }
            }
        }

        private void ValidateXMLAgainstXSD()
        {
            //xmlPath = "C:\\Users\\Perhaps\\Desktop\\KnowledgeRpresentation\\ex12\\schedule.xml";
            //xsdPath = "C:\\Users\\Perhaps\\Desktop\\KnowledgeRpresentation\\ex12\\schedule.xsd";

            //xmlPath = "C:\\Users\\Perhaps\\Desktop\\KnowledgeRpresentation\\ex12\\10_schedule.xml";
            //xsdPath = "C:\\Users\\Perhaps\\Desktop\\KnowledgeRpresentation\\ex12\\10_schedule.xsd";

            if(xsdPath != null)
            {
                if (xmlPath != null)
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.Schemas.Add("http://www.somesite.com/schema/schedule", xsdPath);
                    settings.ValidationType = ValidationType.Schema;

                    XmlReader reader = XmlReader.Create(xmlPath, settings);
                    XmlDocument document = new XmlDocument();
                    document.Load(reader);

                    ValidateXML(ref document);
                }
                else
                {
                    MessageBox.Show("Please provide an xml file first.");
                }
            }
            else
            {
                MessageBox.Show("Please provide an xsd file first.");
            }
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            hasErrorOccured = true;
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    MessageBox.Show(e.Message, "Error:");
                    break;
                case XmlSeverityType.Warning:
                    MessageBox.Show(e.Message, "Warning:");
                    break;
            }
        }

        private void validationButton_Click(object sender, EventArgs e)
        {
            if (xsdPath != null)
            {
                if (xmlPath != null)
                {
                    ValidateXMLAgainstXSD();
                    //ExecuteXPathQuery("//Lesson/Lecture");
                    ExecuteXPathQuery("//Lesson/child::*");
                }
                else
                {
                    MessageBox.Show("Please provide an xml file first.");
                }
            }
            else
            {
                MessageBox.Show("Please provide an xsd file first.");
            }
        }

        private void ValidateXML(ref XmlDocument doc)
        {
            doc.Validate(eventHandler);
            if(hasErrorOccured == false)
            {
                MessageBox.Show("XML Validation against XSD successful.");
                //PopulateResultsDataGridView();
            }
            else
            {
                hasErrorOccured = false;
            }
        }

        private void PopulateResultsDataGridView(string day, string lesson, string prof)
        {
            
            DataRow row = dt.NewRow();
            row["Day"] = day;
            row["Lesson"] = lesson;
            row["Professor"] = prof;
            dt.Rows.Add(row);
        }

        private void ExecuteXPathQuery(string xPath)
        {
            dt = MakeNamesTable();

            if (xmlPath != null)
            {
                XPathDocument document = new XPathDocument(xmlPath);
                XPathNavigator navigator = document.CreateNavigator();
                XPathExpression query;
                XPathNodeIterator nodes;
                object obj = navigator.Evaluate(xPath);
                if (obj != null)
                {
                    query = navigator.Compile(xPath);
                    nodes = navigator.Select(query);

                    string day = null;
                    string lesson = null;
                    string prof = null;
                    tableElements = new List<TableElements>();
                    
                    //int cnt = 0;
                    while (nodes.MoveNext())
                    {
                        //Console.WriteLine("cnt: " + cnt);
                        if(nodes.Current.LocalName == "Title")
                        {
                            Console.WriteLine("0 " + nodes.Current.Value);
                            lesson = nodes.Current.Value;
                            day = null;
                            prof = null;
                        }
                        
                        if(nodes.Current.MoveToChild("Day", navigator.NamespaceURI) == true) 
                        {
                            Console.WriteLine("1 " + nodes.Current.Value);
                            day = nodes.Current.Value;
                            lesson = null;
                            prof = null;
                            nodes.Current.MoveToParent();
                        }     
                        if(nodes.Current.LocalName == "Professor")
                        {
                            Console.WriteLine("3 " + nodes.Current.Value);
                            prof = nodes.Current.Value;
                            lesson = null;
                            day = null;
                        }

                        if(lesson != null)
                        {
                            tableElements.Add(new TableElements());
                            int count = tableElements.Count - 1;
                            tableElements[count].lesson = lesson;
                        }
                        else if(day != null)
                        {
                            int count = tableElements.Count - 1;
                            tableElements[count].day.Add(day);
                        }else if(prof != null)
                        {
                            int count = tableElements.Count - 1;
                            tableElements[count].prof = prof;
                        }
                        //cnt++;
                    }
                }
                else
                {
                    MessageBox.Show("Error in xPath query.");
                }
            }
            else
            {
                MessageBox.Show("xmlPath cannot be null - you must specify an xml file.");
            }
        }

        private DataTable MakeNamesTable()
        {
            // Create a new DataTable titled 'Names'
            DataTable namesTable = new DataTable("Names");

            // Add three column objects to the table.
            DataColumn lessonCol = new DataColumn();
            lessonCol.DataType = System.Type.GetType("System.String");
            lessonCol.ColumnName = "Lesson";
            lessonCol.Unique = false;
            namesTable.Columns.Add(lessonCol);

            DataColumn professorCol = new DataColumn();
            professorCol.DataType = System.Type.GetType("System.String");
            professorCol.ColumnName = "Professor";
            professorCol.Unique = false;
            namesTable.Columns.Add(professorCol);

            DataColumn dayCol = new DataColumn();
            dayCol.DataType = System.Type.GetType("System.String");
            dayCol.ColumnName = "Day";
            dayCol.Unique = false;
            namesTable.Columns.Add(dayCol);

            // Return the new DataTable.
            return namesTable;
        }

        private void FilterDisplay(string selectedDay)
        {
            if(tableElements != null)
            {
                dt = MakeNamesTable();
                foreach (TableElements te in tableElements)
                {
                    foreach (string cur_day in te.day)
                    {
                        if(selectedDay == "all")
                        {
                            PopulateResultsDataGridView(cur_day, te.lesson, te.prof);
                        }
                        else if (cur_day == selectedDay)
                        {
                            PopulateResultsDataGridView(cur_day, te.lesson, te.prof);
                        }
                    }
                }
                resultsDataGridView.DataSource = dt;
            }
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if(tableElements != null)
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Name == "mondayRadioButton")
                {
                    FilterDisplay("Monday");
                }
                else if (rb.Name == "tuesdayRadioButton")
                {
                    FilterDisplay("Tuesday");
                }
                else if (rb.Name == "wednesdayRadioButton")
                {
                    FilterDisplay("Wednesday");
                }
                else if (rb.Name == "thursdayRadioButton")
                {
                    FilterDisplay("Thursday");
                }
                else if (rb.Name == "fridayRadioButton")
                {
                    FilterDisplay("Friday");
                }
                else if (rb.Name == "saturdayRadioButton")
                {
                    FilterDisplay("Saturday");
                }
                else if (rb.Name == "sundayRadioButton")
                {
                    FilterDisplay("Sunday");
                }
                else if (rb.Name == "allDaysRadioButton")
                {
                    FilterDisplay("all");
                }
            }
            else
            {
                MessageBox.Show("Please validate first.");
            }
        }

        private void AddXMLNode(string lesson, string day, string prof)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);

            XmlElement root = doc.DocumentElement;
            XmlElement elementToAdd = doc.CreateElement("Lesson");
            root.AppendChild(elementToAdd);
            
            XmlElement childTitle = doc.CreateElement("Title");
            childTitle.InnerText = lesson;
            root.LastChild.AppendChild(childTitle);

            XmlElement childProfessor = doc.CreateElement("Professor");
            childProfessor.InnerText = prof;
            root.LastChild.AppendChild(childProfessor);

            XmlElement childLec = doc.CreateElement("Lecture");
            root.LastChild.AppendChild(childLec);
            
            XmlElement childDay = doc.CreateElement("Day");
            childDay.InnerText = day;
            root.LastChild.LastChild.AppendChild(childDay);

            doc.Save("C:\\Users\\Perhaps\\Desktop\\KnowledgeRpresentation\\ex12\\new.xml");
        }

        private void addLessonButton_Click(object sender, EventArgs e)
        {
            bool isOK = false;
            if(xmlPath != null)
            {
                if ((titleTextBox.Text != null) && (titleTextBox.Text != ""))
                {
                    if ((dayTextBox.Text != null) && (dayTextBox.Text != ""))
                    {
                        if ((profTextBox.Text != null) && (profTextBox.Text != ""))
                        {
                            AddXMLNode(titleTextBox.Text, dayTextBox.Text, profTextBox.Text);
                            MessageBox.Show("New Lesson added successfully.");
                            isOK = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("xmlPath cannot be null - you must specify an xml file.");
            }

            if(isOK == false)
            {
                MessageBox.Show("Lesson couldn't be added to xml file.");
            }
        }
    }
}

