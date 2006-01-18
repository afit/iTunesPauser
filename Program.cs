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
			iTunesApp application = new iTunesApp();
			
			if( application.PlayerState == ITPlayerState.ITPlayerStateStopped )
				application.Play();
			else
				application.Pause();

		}
	}
}