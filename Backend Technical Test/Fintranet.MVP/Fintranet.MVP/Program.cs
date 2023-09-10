using Fintranet.MVP.Application.Queries;
using Fintranet.MVP.Core.BusinessObjects;
using Fintranet.MVP.Core.Entities;
using Fintranet.MVP.Core.Interfaces.DomainServices;
using Fintranet.MVP.Core.Interfaces.Queries;
using Fintranet.MVP.Core.Models;
using Fintranet.MVP.Infrastracture.DomainServices;
using Fintranet.MVP.Infrastracture.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddEfConfiguraion(builder.Configuration);
builder.Services.AddScoped<IVehiclePassedLogQueries, VehiclePassedLogQueries>();
builder.Services.AddScoped<ITaxCalculation, TaxCalculation>();
builder.Services.AddScoped<IVehicleQueries, VehicleQueries>();

using IHost host = builder.Build();
await host.RunAsync();

var serviceScope = host.Services.CreateScope();
var provider = serviceScope.ServiceProvider;

var passedTimeQuery = provider.GetService<IVehiclePassedLogQueries>();
var vehicleQuery = provider.GetService<IVehicleQueries>();
var vehicles = vehicleQuery.GetAll();

var vahicleBOs = vehicles.Select(x =>

    new VehicleBusinessObject(x.Type, passedTimeQuery.GetPassedLogs(x.Id).Select(q => q.PassedTime).ToArray(), new LocationDto() { Province = x.Location.Province })
).ToList().


//var passedLogs = query.GetPassedLogs(vehicleId);

//List<VehicleEntity> vehicles = new List<VehicleEntity>();

//SeedData();

//void SeedData()
//{

//    vehicles.AddRange(new List<VehicleEntity>() {
//new VehicleEntity
//{
//    Type=Fintranet.MVP.Core.Enums.VehicleTypeEnum.Car,
//    Location=new LocationEntity()
//    {
//        Province=Fintranet.MVP.Core.Enums.ProvinceEnum.Tehran
//    },
//    PassedTimes= new List<PassedLogEntity> (){
//        new PassedLogEntity()
//        {
//            PassedTime=DateTime.Parse("2013-01-14 21:00:00"),
//            VehicleId=1,
//        },
//        new PassedLogEntity()
//        {
//            PassedTime=DateTime.Parse("2013-01-15 21:00:00"),
//            VehicleId=1,
//        }
//        }
//},

//new VehicleEntity
//{
//    Type=Fintranet.MVP.Core.Enums.VehicleTypeEnum.Motorbike,
//    Location=new LocationEntity()
//    {
//        Province=Fintranet.MVP.Core.Enums.ProvinceEnum.Tehran
//    },
//    PassedTimes= new List<PassedLogEntity> (){
//        new PassedLogEntity()
//        {
//            PassedTime=DateTime.Parse("2013-02-07 06:23:27"),
//            VehicleId=1,
//        },
//        new PassedLogEntity()
//        {
//            PassedTime=DateTime.Parse("2013-02-07 15:27:00"),
//            VehicleId=1,
//        }
//        }
//}
//});


//}

//var vehicleId = 1;


Console.WriteLine("");




