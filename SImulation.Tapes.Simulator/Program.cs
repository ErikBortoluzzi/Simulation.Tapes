using Newtonsoft.Json;
using Simulation.Tapes.ApplicationCore.Entities;
using System.Text;

int sections = 7;
int countSections = 1;
int tapesForSection = 9;
int idTape = 1;

var rdm = new Random();
Console.WriteLine("Simulator Start...");
Thread.Sleep(10000);
Console.WriteLine("Simulator Start to Generate");
while (sections >= countSections)
{
    for(int i = 0; i < tapesForSection; i++)
    {
        var tape = new Tape();
        tape.Speed = rdm.Next(20, 60);
        tape.Consume = rdm.Next(35, 60);
        if(tape.Consume < 40)
        {
            tape.Consume = null;
        }
        DateTime now = DateTime.Now;
        tape.Date = now;
        tape.Id = idTape;
        tape.IdSection = countSections;
       try
        {
            using (var client = new HttpClient())
            {
                var endpoint = "https://localhost:7075/api/Tape";
                string stringPayload = System.Text.Json.JsonSerializer.Serialize<Tape>(tape);
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, httpContent).Result.Content.ReadAsStringAsync().Result;
            }
            Console.WriteLine("object insert into database");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        Console.WriteLine(JsonConvert.SerializeObject(tape, Formatting.Indented));
        idTape++;
       Thread.Sleep(15000);
    }
    countSections++;
}

