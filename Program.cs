using System;
using System.Collections.Generic;
using System.Windows.Forms;

using iTunesLib;

namespace iTunesPauser {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main() {
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler( UnhandledException );
			iTunesApp application = new iTunesApp();
			
			if( application.PlayerState == ITPlayerState.ITPlayerStateStopped )
				application.Play();
			else
				application.Pause();
		}
		
		private static void UnhandledException( Object sender, UnhandledExceptionEventArgs e ) { 
			// Likely exceptions will stem from the Interop object,
			// although given changes in its version there are a
			// variety of cryptic causes. Frankly, we're best off
			// failing silently and terminating, so our unhandled
			// exception goes... largely unhandled.
		}
	}
}