# Auto-update-module-in-CSharp

Add the DLL to your program and use the following code to check for updates

    private auto_update.AutoUpdate autoUpdate;
    private void CheckForUpdates_Click(object sender, EventArgs e)
    {
    	if (autoUpdate == null)
    		autoUpdate = new auto_update.AutoUpdate(this);
    	string assemblyVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
    	autoUpdate.SetConfiguration("Application.exe", assemblyVer, "http://localhost:8000/update.xml");
    	autoUpdate.CheckForUpdates();
    }
    
    private void timer1_Tick(object sender, EventArgs e)
    {
    	timer1.Stop();
    	if (autoUpdate == null)
    		autoUpdate = new auto_update.AutoUpdate(this);
    	autoUpdate.Cleanup();
    }

