using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string eventSelected = GetSelectedEvent();
            bool isConsentGiven = checkBoxConsent.Checked;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(eventSelected))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            if (!isConsentGiven)
            {
                MessageBox.Show("You must agree to the consent policy.");
                return;
            }

            // Create PDF
            GeneratePDF(name, email, eventSelected);
            MessageBox.Show("PDF generated successfully!");
        }
            
        private string GetSelectedEvent()
        {
            if (radioButtonDesign.Checked) return "Design";
            if (radioButtonDebugging.Checked) return "Debugging";
            if (radioButtonPhotography.Checked) return "Photography";
            return string.Empty;
        }

        private void GeneratePDF(string name, string email, string eventSelected)
        {
            string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{name}_ConsentForm.pdf");
            

            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
            doc.Open();

            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            var sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);

            doc.Add(new Paragraph("Thulir Skill Contest - Consent Letter", titleFont));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph($"Participant Name: {name}", normalFont));
            doc.Add(new Paragraph($"Email: {email}", normalFont));
            doc.Add(new Paragraph($"Activity Involved: {eventSelected}", normalFont));
            doc.Add(new Paragraph("\n"));

            // Event-based description
            string description = "";
            string[] rules;
            string[] valuation;

            switch (eventSelected)
            {
                case "Design":
                    description = "The design event focuses on creativity and visual problem-solving through digital tools.";
                    rules = new string[]
                    {
                        "Participants must submit original work.",
                        "Designs should be submitted in .png or .jpeg format.",
                        "Use of AI-generated content is not allowed."
                    };
                    valuation = new string[]
                    {
                        "Creativity and originality - 40%",
                        "Visual appeal and clarity - 30%",
                        "Relevance to theme - 30%"
                    };
                    break;

                case "Debugging":
                    description = "The debugging event challenges participants to identify and fix code errors efficiently.";
                    rules = new string[]
                    {
                        "Participants must solve given code problems.",
                        "Use of online IDEs is allowed.",
                        "Each bug fixed must be documented."
                    };
                    valuation = new string[]
                    {
                        "Bug detection accuracy - 40%",
                        "Efficiency and speed - 30%",
                        "Explanation clarity - 30%"
                    };
                    break;

                case "Photography":
                    description = "The photography event captures creativity and storytelling through images.";
                    rules = new string[]
                    {
                        "All photos must be original.",
                        "Minimal editing allowed.",
                        "Submit high-resolution images."
                    };
                    valuation = new string[]
                    {
                        "Creativity and composition - 40%",
                        "Technical quality - 30%",
                        "Relevance to theme - 30%"
                    };
                    break;

                default:
                    description = "No description available.";
                    rules = new string[0];
                    valuation = new string[0];
                    break;
            }

            doc.Add(new Paragraph("Description:", sectionFont));
            doc.Add(new Paragraph(description, normalFont));
            doc.Add(new Paragraph("\nRules:", sectionFont));
            foreach (var rule in rules)
            {
                doc.Add(new Paragraph($"• {rule}", normalFont));
            }

            doc.Add(new Paragraph("\nValuation Criteria:", sectionFont));
            foreach (var val in valuation)
            {
                doc.Add(new Paragraph($"• {val}", normalFont));
            }

            doc.Add(new Paragraph("\nAgreement:", sectionFont));
            doc.Add(new Paragraph("I hereby declare that I have read and understood the participation policy of the Thulir Skill Contest. I agree to abide by all the rules and regulations stated for the event I have chosen.", normalFont));
            doc.Add(new Paragraph("I give my full consent to the organizers to use my submitted information and content for the purpose of documentation, reporting, and showcasing. I understand that my data may be used for internal analysis and promotional materials related to the contest.", normalFont));

            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph($"Signature: {name}", normalFont));
            doc.Add(new Paragraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}", normalFont));

            doc.Close();
        } 
    }
}
