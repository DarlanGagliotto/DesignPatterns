using System;

namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        public Celular _Celular;

        public AndroidBuilder()
        {
            this._Celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            this._Celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this._Celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            this._Celular.Sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            this._Celular.Tela = "7";
        }

        public Celular Celular
        {
            get { return this._Celular; }
        }
    }
}
