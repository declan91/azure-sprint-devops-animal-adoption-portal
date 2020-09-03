using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Merret", Age = 3, Description = "Cute as hell Ferret. \n The ferret (Mustela putorius furo) is the domesticated form of the European polecat, a mammal belonging to the same genus as the weasel, Mustela, in the family Mustelidae.[1] Their fur is typically brown, black, white, or mixed. They have an average length of 51 cm (20 in), including a 13 cm (5.1 in) tail, weigh about between 0.7 and 2.0 kg (1.5 and 4.4 lb), and have a natural lifespan of 7 to 10 years.[2] Ferrets are sexually dimorphic predators, with males being substantially larger than females." },
           
        };
    }
}
