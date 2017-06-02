using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCoreAngular.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder builder)
        {
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Blæset')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Dala')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Gammelnorsk')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Gammelnorsk Spæl')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Grå Trønder')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Finsk Landrase')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Fuglestadbrogete')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Merino')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Norsk Kvit')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Norsk Pelssau')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Oxford Down')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Rygja')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Sjeviot')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Spæl')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Steigar')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Suffolk')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Svartfjes')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Texel')");
            builder.Sql("INSERT INTO Breeds (Name) VALUES ('Østfrisisk')");

            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('1640082', (SELECT ID FROM Breeds WHERE Name = 'Blæset'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('6492578', (SELECT ID FROM Breeds WHERE Name = 'Dala'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('3190568', (SELECT ID FROM Breeds WHERE Name = 'Gammelnorsk'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('9153485', (SELECT ID FROM Breeds WHERE Name = 'Gammelnorsk Spæl'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('9130524', (SELECT ID FROM Breeds WHERE Name = 'Grå Trønder'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('2978854', (SELECT ID FROM Breeds WHERE Name = 'Finsk Landrase'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('1104668', (SELECT ID FROM Breeds WHERE Name = 'Fuglestadbrogete'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('3348325', (SELECT ID FROM Breeds WHERE Name = 'Merino'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('6755492', (SELECT ID FROM Breeds WHERE Name = 'Norsk Kvit'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('1994625', (SELECT ID FROM Breeds WHERE Name = 'Norsk Pelssau'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('3779048', (SELECT ID FROM Breeds WHERE Name = 'Oxford Down'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('6154885', (SELECT ID FROM Breeds WHERE Name = 'Rygja'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('3409775', (SELECT ID FROM Breeds WHERE Name = 'Sjeviot'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('6499875', (SELECT ID FROM Breeds WHERE Name = 'Spæl'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('3155400', (SELECT ID FROM Breeds WHERE Name = 'Steigar'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('9154778', (SELECT ID FROM Breeds WHERE Name = 'Suffolk'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('3265889', (SELECT ID FROM Breeds WHERE Name = 'Svartfjes'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('2405788', (SELECT ID FROM Breeds WHERE Name = 'Texel'))");
            builder.Sql("INSERT INTO Sheep (Number, BreedID) VALUES ('6112420', (SELECT ID FROM Breeds WHERE Name = 'Østfrisisk'))");
        }

        protected override void Down(MigrationBuilder builder)
        {
            builder.Sql("DELETE FROM Breeds WHERE (Name) IN ('Blæset','Dala','Gammelnorsk','Gammelnorsk Spæl','Grå Trønder','Finsk Landrase','Fuglestadbrogete','Merino','Norsk Kvit','Norsk Pelssau','Oxford Down','Rygja','Sjeviot','Spæl','Steigar','Suffolk','Svartfjes','Texel','Østfrisisk')");
        }
    }
}
