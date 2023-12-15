using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakte
{
    public class Contacts
    {

        public string Name { get; set; }

        public string email { get; set; }

        public string phone { get; set; }



    }
    public class ContactList
    {
        
        public BindingList<Contacts> Contacts { get; } = new BindingList<Contacts>();

        public void Clear()
        {
            if (Contacts.Count != null)
            {
                Contacts.Clear(); 

            }

        }
        public void ExportCsv(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Schreiben der Spaltenüberschriften
                    writer.WriteLine("Name,Email,Phone");

                    // Schreiben der Kontaktdaten
                    foreach (var contact in Contacts)
                    {
                        writer.WriteLine($"{contact.Name},{contact.email},{contact.phone}");
                    }
                }

                Console.WriteLine($"Kontakte erfolgreich nach {filePath} exportiert.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Exportieren der Kontakte: {ex.Message}");
            }
        }

        public void ImportCsv(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Überspringen der Spaltenüberschriften
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        // Hinzufügen eines neuen Kontakts
                        Contacts.Add(new Contacts
                        {
                            Name = values[0],
                            email = values[1],
                            phone = values[2]
                        });
                    }
                }

                Console.WriteLine($"Kontakte erfolgreich von {filePath} importiert.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Importieren der Kontakte: {ex.Message}");
            }
        }
    }
}







