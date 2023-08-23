
# .NET 6 Core Ocelot Gateway ve Consul Service Discovery
![](https://media.istockphoto.com/id/617886480/tr/foto%C4%9Fraf/ocelot.jpg?s=612x612&w=0&k=20&c=R-H2qZ-pmquMBjM3R57H6mXIHyWNUIpiGgzuhskSM7E=)

Bu proje, Ocelot Gateway'i kullanarak servislerin Consul hizmet keşfi ile kaydedildiği bir örnektir.

## Başlangıç

Bu talimatlar, projenin yerel geliştirme ve test amacıyla nasıl kurulacağını açıklar. Canlı bir ortamda dağıtım için farklı adımlar gerekebilir.

### Tech Stack

.NET 6 Core, Ocelot,Servisler için Consul ve Ocelot Gateway için ocelot.provider.consul package

### Kurulum

1. Bu repoyu klonlayın:

```bash
git clone https://github.com/ramalt/NET6-Core-Ocelot-Gateway-Consul-Discover.git
cd NET6-Core-Ocelot-Gateway-Consul-Discover
```
2. Consul 'u başlatın:

```bash
consul agent -dev
```
3. Ocelot Gateway'i başlatın:

```bash
cd ApiGateway/
dotnet restore
dotnet run
```
4. Servisleri başlatın:

```bash
cd ../Services/ContactAPI/Contact.API/ 
dotnet restore
dotnet run
```
```bash
cd ../Services/ReservationAPI/Reservation.API/ 
dotnet restore
dotnet run
```

## Kullanım
### Endpoints

##### ContactAPI:

GET: http://localhost:8001/api/contact/{id}

##### ReservationAPI:

GET: http://localhost:8002/api/reservation/{id}

##### ApiGateway:

GET: http://localhost:8000/c/{id} - contact service endpoint

GET: http://localhost:5000/r/{id} - reservation service endpoint

