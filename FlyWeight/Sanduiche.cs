using System;


namespace FlyWeight {
    public abstract class Sanduiche : ISanduiche {

        //IFlyweight Complementaçãos
        public abstract double Preco { get; }

        public override string ToString() {

            return String.Format("{0} - {1:c}", this.GetType().Name, this.Preco);

        }

    }
}
