namespace TimeTracker.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecordData>().HasData(
                    new RecordData
                    {
                        Id = 1,
                        Date = DateTime.Parse("2023-11-1") ,
                        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
                        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
                        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
                        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")
                    },
                    new RecordData
                    {
                        Id = 2,
                        Date = DateTime.Parse("2023-11-2") ,
                        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
                        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
                        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
                        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")

                    },
                    new RecordData
                    {
                        Id = 3,
                        Date = DateTime.Parse("2023-11-3") ,
                        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
                        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
                        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
                        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")
                    },
                    new RecordData
                    {
                        Id = 4,
                        Date = DateTime.Parse("2023-11-4"),
                        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
                        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
                        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
                        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")
                    },
                    new RecordData
                    {
                        Id = 5,
                        Date = DateTime.Parse("2023-11-5"),
                        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
                        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
                        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
                        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")
                    },
                    new RecordData
                    {
                        Id = 6,
                        Date = DateTime.Parse("2023-11-6"),
                        WorkStartTimeMorning = DateTime.Parse("8:30:00"),
                        WorkEndTimeMorning = DateTime.Parse("12:00:00"),
                        WorkStartTimeAfternoon = DateTime.Parse("13:30:00"),
                        WorkEndTimeAfternoon = DateTime.Parse("17:00:00")
                    }
                );
        }

        public DbSet<RecordData> RecordDatas { get; set; }
    }
}
