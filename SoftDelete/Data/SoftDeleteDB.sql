USE [SoftDeleteDB]
GO
INSERT [dbo].[Courses] ([CourseID], [Title], [Credits]) VALUES (1045, N'Calculus', 4)
INSERT [dbo].[Courses] ([CourseID], [Title], [Credits]) VALUES (1050, N'Chemistry', 3)
INSERT [dbo].[Courses] ([CourseID], [Title], [Credits]) VALUES (2021, N'Composition', 3)
INSERT [dbo].[Courses] ([CourseID], [Title], [Credits]) VALUES (2042, N'Literature', 4)
INSERT [dbo].[Courses] ([CourseID], [Title], [Credits]) VALUES (3141, N'Trigonometry', 4)
INSERT [dbo].[Courses] ([CourseID], [Title], [Credits]) VALUES (4022, N'Microeconomics', 3)
INSERT [dbo].[Courses] ([CourseID], [Title], [Credits]) VALUES (4041, N'Macroeconomics', 3)
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (1, N'Alexander', N'Carson', CAST(N'2005-09-01T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (2, N'Alonso', N'Meredith', CAST(N'2002-09-01T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (3, N'Anand', N'Arturo', CAST(N'2003-09-01T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (4, N'Barzdukass', N'Gytis', CAST(N'2002-09-01T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (5, N'Li', N'Yan', CAST(N'2002-09-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (6, N'Justice', N'Peggy', CAST(N'2001-09-01T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (7, N'Norman', N'Laura', CAST(N'2003-09-01T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Students] ([ID], [LastName], [FirstMidName], [EnrollmentDate], [IsDeleted]) VALUES (8, N'Olivetto', N'Nino', CAST(N'2005-09-01T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Enrollments] ON 

INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (1, 1050, 1, 0)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (2, 4022, 1, 2)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (3, 4041, 1, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (4, 1045, 2, 1)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (5, 3141, 2, 4)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (6, 2021, 2, 4)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (7, 1050, 3, NULL)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (8, 1050, 4, NULL)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (9, 4022, 4, 4)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (10, 4041, 5, 2)
INSERT [dbo].[Enrollments] ([EnrollmentID], [CourseID], [StudentID], [Grade]) VALUES (11, 1045, 6, NULL)
SET IDENTITY_INSERT [dbo].[Enrollments] OFF
GO
