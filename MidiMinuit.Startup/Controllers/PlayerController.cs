using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidiMinuit.Startup.Models;

namespace MidiMinuit.Startup.Controllers
{
    public class PlayerController : Controller
    {
        private static readonly IList<InstrumentModel> _instruments;

        static PlayerController()
        {
            _instruments = new List<InstrumentModel>
            {
                new InstrumentModel
                {
                    Id = 1,
                    Name = "Guitar",
                    Text = "A 6 chord instrument",
                    Icon = "http://icones.pro/go.php?http://icdn.pro/images/fr/g/u/guitare-instrument-musique-rock-icone-6693-128.png"
                },
                new InstrumentModel
                {
                    Id = 2,
                    Name = "Piano",
                    Text = "An instrument with many keys",
                    Icon = "http://icones.pro/go.php?http://icdn.pro/images/fr/c/l/clavier-midi-synthe-icone-3791-128.png"
                },
                new InstrumentModel
                {
                    Id = 3,
                    Name = "Drums",
                    Text = "Poum poum chak",
                    Icon = "http://icones.pro/go.php?http://icdn.pro/images/fr/a/p/appareil-photo-canon-dslr-objectif-reflex-icone-6657-128.png"
                }
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("instruments")]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Instruments()
        {
            return Json(_instruments);
        }
    }
}