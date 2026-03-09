# Koristimo zvanični .NET 8 SDK image kao bazu, koji sadrži .NET kompajler i runtime.
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Postavljamo radni direktorijum unutar kontejnera na /app.
# Sve naredne komande (COPY, RUN, CMD...) izvršavaće se u ovom folderu.
WORKDIR /app

# Kopiramo sadržaj trenutnog foldera (projekat) u /app folder unutar kontejnera.
# Ovo uključuje .csproj, source code, konfiguracione fajlove itd.
COPY . .

# Pokrećemo komandu za build.
# Ovo kompajlira aplikaciju unutar kontejnera i priprema je za pokretanje.
RUN dotnet build -c Release

# CMD definiše komandu koja se izvršava kada se kontejner startuje.
# U ovom slučaju: pokreće aplikaciju preko `dotnet run` i postavlja na port 44333.
CMD ["dotnet", "run", "--urls", "http://0.0.0.0:44333"]

# EXPOSE samo dokumentuje upotrebu port 44333, ne otvara ga (tu nam treba -p 44333:44333).
EXPOSE 44333