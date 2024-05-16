# Update package index
apk update

# Install OpenJDK 11
apk add openjdk11



# Install required dependencies
apk add curl libc6-compat

# Download and install .NET SDK
curl -L -o dotnet.tar.gz https://download.visualstudio.microsoft.com/download/pr/140bf5b3-cb8f-46ae-bd36-5f9c020ab267/ebe5d6155fcf165d1f527a51d52cf0b2/dotnet-sdk-6.0.200-linux-musl-x64.tar.gz
mkdir -p /usr/share/dotnet
tar -zxf dotnet.tar.gz -C /usr/share/dotnet
ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet
rm dotnet.tar.gz

apk add maven

mvn clean install

dotnet build


java -jar YourJavaApp.jar
dotnet YourDotNetApp.dll https://abc.com
