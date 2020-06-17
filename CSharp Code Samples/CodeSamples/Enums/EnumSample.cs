using System;
using System.ComponentModel;
using CodeSamples.Alterations.Extensions;

namespace CodeSamples.Enums
{
    /// <summary>
    /// Classic enum
    /// </summary>
    internal enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    /// <summary>
    /// Classic enum with type and defined values
    /// </summary>
    internal enum Priority : short
    {
        Lowest = -2,
        Low = -1,
        Normal = 0,
        High = 1,
        Highest = 2
    }

    /// <summary>
    /// Flags enum
    /// </summary>
    [Flags]
    internal enum SidesAndCorners
    {
        None = 0,
        Top = 1,
        Bottom = 2,
        Left = 4,
        Right = 8,
        //
        TopLeft = Top | Left,
        TopRight = Top | Right,
        BottomLeft = Bottom | Left,
        BottomRight = Bottom | Right,
        //
        Full = Top | Bottom | Left | Right
    }

    /// <summary>
    /// Enum with description attribute
    /// </summary>
    internal enum Status
    {
        [Description("Not Completed")]
        NotCompleted,
        Completed,
        Error
    }

    public class EnumSample : SampleExecute
    {
        private void OutputSidesAndCorners(SidesAndCorners sidesAndCorners)
        {
            Console.WriteLine($"SidesAndCorners Enum values: default={sidesAndCorners.ToString()}, string={sidesAndCorners.ToString("g")}, flags={sidesAndCorners.ToString("f")}, decimal={sidesAndCorners.ToString("d")}, hex=0x{sidesAndCorners.ToString("x")}");
        }

        public override void Execute()
        {
            Title("EnumSampleExecute");

            Section("Simple Enum");
            //'This must be Thursday,' said Arthur to himself, sinking low over his beer. 'I never could get the hang of Thursdays.'
            WeekDay weekDay = WeekDay.Thursday; 
            Console.WriteLine($"weekDay Enum value: default={weekDay.ToString()}, string={weekDay.ToString("g")}, decimal={weekDay.ToString("d")}, hex=0x{weekDay.ToString("x")}");
            var enumValues = Enum.GetNames(typeof(WeekDay));
            Console.WriteLine("WeekDays Enum values:");
            foreach (string value in enumValues)
            {
                Console.WriteLine(value);
            }
            LineBreak();

            Section("Typed Enum (short)");
            Priority priority = Priority.Low;
            Console.WriteLine($"Priority Enum values: default={priority.ToString()}, string={priority.ToString("g")}, decimal={priority.ToString("d")}, hex=0x{priority.ToString("x")}");
            priority = Priority.Normal;
            Console.WriteLine($"Priority Enum values: default={priority.ToString()}, string={priority.ToString("g")}, decimal={priority.ToString("d")}, hex=0x{priority.ToString("x")}");
            priority = Priority.Highest;
            Console.WriteLine($"Priority Enum values: default={priority.ToString()}, string={priority.ToString("g")}, decimal={priority.ToString("d")}, hex=0x{priority.ToString("x")}");


            Section("Enum Flags");
            SidesAndCorners sidesAndCorners = SidesAndCorners.Bottom;
            OutputSidesAndCorners(sidesAndCorners);
            sidesAndCorners = SidesAndCorners.Full;
            OutputSidesAndCorners(sidesAndCorners);
            sidesAndCorners = SidesAndCorners.Top | SidesAndCorners.Bottom;
            OutputSidesAndCorners(sidesAndCorners);
            sidesAndCorners = SidesAndCorners.TopLeft;
            OutputSidesAndCorners(sidesAndCorners);

            //checking flags
            Console.WriteLine($"sidesAndCorners.Top is set={sidesAndCorners.HasFlag(SidesAndCorners.Top)}");
            Console.WriteLine($"sidesAndCorners.TopLeft is set={sidesAndCorners.HasFlag(SidesAndCorners.TopLeft)}");
            Console.WriteLine($"sidesAndCorners.Full is set={sidesAndCorners.HasFlag(SidesAndCorners.Full)}");
            Console.WriteLine($"sidesAndCorners.Bottom is set={sidesAndCorners.HasFlag(SidesAndCorners.Bottom)}");

            Section("Enum with Description");
            Status status= Status.NotCompleted;
            Console.WriteLine($"status value: default={status.ToString()}, string={status.ToString("g")}, decimal={status.ToString("d")}, hex=0x{status.ToString("x")}");
            var statusValues = Enum.GetValues(typeof(Status));
            Console.WriteLine("Status Enum values:");
            foreach (Status value in statusValues)
            {
                Console.WriteLine($"ordinal={(int)value}, value={value.ToString()}, description={value.GetDescription<Status>()}");
            }
            LineBreak();

            Finish();
        }
    }
}
