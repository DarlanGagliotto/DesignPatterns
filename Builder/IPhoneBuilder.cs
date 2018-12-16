using System;

namespace Builder
{
   public class IPhoneBuilder : ICelular
    {
        public Celular _Celular;

        public IPhoneBuilder()
        {
            this._Celular = new Celular("IPhone");
        }

        public void BuildBateria()
        {
            this._Celular.Bateria = "MAC_6321";
        }

        public void BuildCamera()
        {
            this._Celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            this._Celular.Sistema = "IOS 10.3";
        }

        public void BuildTela()
        {
            this._Celular.Tela = "9";
        }

        public Celular Celular
        {
            get { return this._Celular; }
        }
    }
}
