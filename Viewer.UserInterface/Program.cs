//_______________________________________________________________
//  Title   : main Program of OPC.UA.Viewer
//  System  : Microsoft VisualStudio 2015 / C#
//  $LastChangedDate:  $
//  $Rev: $
//  $LastChangedBy: $
//  $URL: $
//  $Id:  $
//
//  Copyright (C) 2016, CAS LODZ POLAND.
//  TEL: +48 (42) 686 25 47
//  mailto://techsupp@cas.eu
//  http://www.cas.eu
//_______________________________________________________________


using CAS.CommServer.UA.Viewer.UserInterface.Properties;
using CAS.Lib.CodeProtect;
using Opc.Ua;
using Opc.Ua.Configuration;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Windows.Forms;

namespace CAS.CommServer.UA.Viewer.UserInterface
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      ApplicationInstance _application = new ApplicationInstance();
      _application.ApplicationName = "CommServer OPC UA Viewer";
      AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 40, $"starting application {_application.ApplicationName}");
      _application.ApplicationType = ApplicationType.Client;
      _application.ConfigSectionName = Settings.Default.ConfigurationSectionName;
      string _commandLine = Environment.CommandLine;
      if (IsFirstRun() || _commandLine.ToLower().Contains(m_InstallLicenseString))
      {
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 40, $"Installing license");
        DoInstallLicense(true);
      }
      try
      {
        // process the command line arguments.
        if (_application.ProcessCommandLine(true))
          return;
        // load the application configuration.
        _application.LoadApplicationConfiguration(false);
        // check the application certificate.
        _application.CheckApplicationInstanceCertificate(false, 0);
        // start the server.
        //application.Start(new SampleServer());
        // run the application interactively.
        m_ApplicationEntryForm = new OpcUaClientForm(_application, null, _application.ApplicationConfiguration);
        DoApplicationRun(Application.Run);
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Verbose, 40, $"Application finished");
      }
      catch (Exception e)
      {
        AssemblyTraceEvent.Tracer.TraceEvent(TraceEventType.Error, 40, $"Application finished with exception {e})");
        ExceptionDlg.Show(_application.ApplicationName, e);
      }
    }
    internal static void DoInstallLicense(bool loadLicenseFromDefaultContainer)
    {
      try
      {
        LibInstaller.InstallLicense(loadLicenseFromDefaultContainer);
      }
      catch (Exception ex)
      {
        MessageBoxShow(string.Format(Resources.MainProgram_LicenseInstalation_Failure, ex.Message));
      }
    }
    internal static void DoApplicationRun(Action<Form> applicationRun)
    {
      applicationRun(m_ApplicationEntryForm);
    }
    internal static Func<string, DialogResult> MessageBoxShow { get { return m_MessageBoxShow; } set { m_MessageBoxShow = value; } }

    private static Func<string, DialogResult> m_MessageBoxShow = x => MessageBox.Show(x, Resources.MainProgram_LicenseInstalation_Failure_Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    private readonly static string m_InstallLicenseString = "installic";
    private static Form m_ApplicationEntryForm;
    private static bool IsFirstRun()
    {
      try
      {
        return ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.IsFirstRun;
      }
      catch (DeploymentException)
      {
        return false;
      }
    }

  }
}
