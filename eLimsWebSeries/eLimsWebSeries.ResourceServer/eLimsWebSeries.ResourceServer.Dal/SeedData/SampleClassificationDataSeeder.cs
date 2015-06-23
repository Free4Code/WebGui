namespace eLimsWebSeries.ResourceServer.Dal.SeedData
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    using eLimsWebSeries.ResourceServer.Dal.DataContext;
    using eLimsWebSeries.ResourceServer.Entity.Entities;
    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    internal class SampleClassificationDataSeeder
    {
        private readonly SampleClassificationContext context;

        public SampleClassificationDataSeeder(SampleClassificationContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            if (this.context.DesignOfMatrices.Any())
            {
                return;
            }

            try
            {
                foreach (var dataMatrix in dataMatrices)
                {
                    var dataMatrixSplitted = SplitValue(dataMatrix);
                    var matrix = new DesignOfMatrix
                                     {
                                         Code = dataMatrixSplitted[0],
                                         Hierarchy =
                                             string.IsNullOrWhiteSpace(dataMatrixSplitted[1])
                                                 ? null
                                                 : dataMatrixSplitted[1],
                                         Type = dataMatrixSplitted[2],
                                         InternalName = dataMatrixSplitted[3],
                                         InternalComment = dataMatrixSplitted[4],
                                         State = dataMatrixSplitted[5],
                                         //Trackings =
                                         //    new Collection<MatrixTracking>
                                         //        {
                                         //            new MatrixTracking
                                         //                {
                                         //                    State = dataMatrixSplitted[5],
                                         //                    StateAction = "SeedData",
                                         //                    UserCode = "Admin",
                                         //                    StateDate = DateTime.Now
                                         //                }
                                         //        }
                                     };
                    this.context.DesignOfMatrices.Add(matrix);
                    this.context.SaveChanges();
                }

                //for (int i = 0; i < tutorNames.Length; i++)
                //{
                //    var nameGenderMail = SplitValue(tutorNames[i]);
                //    var tutor = new Tutor
                //                    {
                //                        Email =
                //                            String.Format(
                //                                "{0}.{1}@{2}",
                //                                nameGenderMail[0],
                //                                nameGenderMail[1],
                //                                nameGenderMail[3]),
                //                        UserName = String.Format("{0}{1}", nameGenderMail[0], nameGenderMail[1]),
                //                        Password = RandomString(8),
                //                        FirstName = nameGenderMail[0],
                //                        LastName = nameGenderMail[1],
                //                        Gender =
                //                            ((Enums.Gender)Enum.Parse(typeof(Enums.Gender), nameGenderMail[2]))
                //                    };
                //    this.context.Tutors.Add(tutor);
                //    var courseSubject = _ctx.Subjects.Where(s => s.Id == i + 1).Single();
                //    foreach (var CourseDataItem in CoursesSeedData.Where(c => c.SubjectID == courseSubject.Id))
                //    {
                //        var course = new Course
                //                         {
                //                             Name = CourseDataItem.CourseName,
                //                             CourseSubject = courseSubject,
                //                             CourseTutor = tutor,
                //                             Duration = new Random().Next(3, 6),
                //                             Description =
                //                                 String.Format(
                //                                     "The course will talk in depth about: {0}",
                //                                     CourseDataItem.CourseName)
                //                         };
                //        this.context.Courses.Add(course);
                //    }
                //}

                //context.SaveChanges();
            }

            catch (Exception ex)
            {
                string message = ex.ToString();
                throw ex;
            }
        }

        private static string[] SplitValue(string val)
        {
            return val.Split(',');
        }

        private static string[] dataMatrices =
            {
                "AAA01,,M,MATRIX INTERNAL NAME PLOP,MATRIX INTERNAL COMMENT PLOP,C",
                "AAA02,,M,MATRIX INTERNAL NAME TOTO,MATRIX INTERNAL COMMENT TOTO,C",
                "AAA03,,M,MATRIX INTERNAL NAME TITI,MATRIX INTERNAL COMMENT TITI,C",
                "AAA04,,M,MATRIX INTERNAL NAME BOB,MATRIX INTERNAL COMMENT BOB,C"
            };

        ////private string RandomString(int size)
        ////{
        ////    Random _rng = new Random((int)DateTime.Now.Ticks);
        ////    string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        ////    char[] buffer = new char[size];
        ////    for (int i = 0; i < size; i++)
        ////    {
        ////        buffer[i] = _chars[_rng.Next(_chars.Length)];
        ////    }

        ////    return new string(buffer);
        ////}
    }
}