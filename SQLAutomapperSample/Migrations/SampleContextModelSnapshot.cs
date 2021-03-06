﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLAutomapperSample.DataAccess;

namespace SQLAutomapperSample.Migrations
{
    [DbContext(typeof(SampleContext))]
    partial class SampleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SQLAutomapperSample.DataAccess.Models.SampleOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreateDate");

                    b.Property<byte>("DEA");

                    b.Property<Guid>("DeliveryMethodKey");

                    b.Property<Guid>("DiscontinuedByKey");

                    b.Property<DateTime>("DiscontinuedDatetime");

                    b.Property<bool>("DoNotCrush");

                    b.Property<short>("DurationDays");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("FP");

                    b.Property<bool>("ForPain");

                    b.Property<decimal>("GCN_SEQNO");

                    b.Property<string>("Instructions");

                    b.Property<string>("Item");

                    b.Property<string>("ItemDescription");

                    b.Property<byte>("KopPrivilegeStatusId");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<bool>("OffFormulary");

                    b.Property<Guid>("OrderKey");

                    b.Property<string>("OrderNo");

                    b.Property<Guid>("OrderStatusKey");

                    b.Property<Guid>("OrderTypeKey");

                    b.Property<bool>("PRN");

                    b.Property<byte>("PharmacyDeliveryTypeId");

                    b.Property<bool>("ProfileOrder");

                    b.Property<decimal>("Quantity");

                    b.Property<decimal>("QuantityMax");

                    b.Property<short>("RefillMaxDays");

                    b.Property<byte>("Refills");

                    b.Property<Guid>("ResidentKey");

                    b.Property<Guid>("ScheduleKey");

                    b.Property<bool>("SendToPharmacy");

                    b.Property<Guid>("SiteKey");

                    b.Property<DateTime>("StartDate");

                    b.Property<Guid>("SubmittedByKey");

                    b.Property<DateTime>("SubmittedDatetime");

                    b.Property<decimal>("Total");

                    b.Property<string>("TranscribeMethod");

                    b.Property<Guid>("TranscribedForKey");

                    b.Property<string>("UOM");

                    b.Property<Guid>("VaccinationKey");

                    b.HasKey("Id");

                    b.ToTable("SampleOrderDbSet");
                });
#pragma warning restore 612, 618
        }
    }
}
