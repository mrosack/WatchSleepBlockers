dotnet publish -c Release -f netcoreapp3.1 -r win10-x64 --self-contained false

powershell Compress-Archive -Force WatchSleepBlockers\bin\Release\netcoreapp3.1\win10-x64\publish\*.* WatchSleepBlockers.zip