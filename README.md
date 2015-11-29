# StudyServer
To run locally on win:<br/>
1. Run cmd and fire the fallowing script in order to download dnvm<br/>
<code>@powershell -NoProfile -ExecutionPolicy unrestricted -Command "&{$Branch='dev';iex ((new-object net.webclient).DownloadString('https://raw.githubusercontent.com/aspnet/Home/dev/dnvminstall.ps1'))}"</code><br/>
2. Upgrade to the newest clr <br/>
<code>dnvm upgrade -r coreclr</code><br/>
3. Run web command on the project<br/>
<code>dnx web</code>

App should be accessible on localhost:5000 by default.
