@echo off
powershell mkdir %APPDATA%\VideoRecoder_Luncher || powershell rm -r %APPDATA%\VideoRecoder_Luncher && powershell mkdir %APPDATA%\VideoRecoder_Luncher
powershell cp * %APPDATA%\VideoRecoder_Luncher || exit 1
cd %APPDATA%\VideoRecoder_Luncher || exit 1
.\7z x publish.tar.gz.001 || exit 1
.\7z x publish.tar || exit 1
start explorer %APPDATA%\VideoRecoder_Luncher
.\VideoRecoder_Luncher
exit 0