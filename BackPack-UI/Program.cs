namespace BackPack_UI
{
    public static class Program
    {
        public static ChooseAction ChooseAction = new ChooseAction();
        public static Form_Manual Form_main 
        {
            get{ return ChooseAction.Form1; }
        }
       

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ChooseAction);
        }
    }   

}