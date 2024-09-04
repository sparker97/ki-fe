var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.KI_Front_End>("ki-front-end");

builder.Build().Run();
