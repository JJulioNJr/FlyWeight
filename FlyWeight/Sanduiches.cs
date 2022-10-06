using System;
using System.Collections.Generic;

namespace FlyWeight {

    //FlyweightFactory
    public class Sanduiches {

        Dictionary<int, ISanduiche> sanduiches =

        new Dictionary<int, ISanduiche>();

        public Sanduiches() {

            sanduiches.Clear();

            sanduiches.Add(1, new Hamburger());

            sanduiches.Add(2, new Lanche());

            sanduiches.Add(3, new Misto());

        }

        //flyweights
        public ISanduiche this[int index] {

            get {

                return sanduiches[index];

            }

        }
    }
}
