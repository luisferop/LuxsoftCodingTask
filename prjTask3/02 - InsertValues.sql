
INSERT [dbo].[Clients] ([client_id], [client_name]) VALUES (1, N'Luis');
INSERT [dbo].[Clients] ([client_id], [client_name]) VALUES (2, N'Klaudia');
INSERT [dbo].[Clients] ([client_id], [client_name]) VALUES (3, N'Kasia');
INSERT [dbo].[Orders] ([order_id], [order_date], [client_id], [order_sum]) VALUES (1, CAST(N'2018-01-01T00:00:00.000' AS DateTime), 1, 30);
INSERT [dbo].[Orders] ([order_id], [order_date], [client_id], [order_sum]) VALUES (2, CAST(N'2018-01-01T00:00:00.000' AS DateTime), 1, 30);
INSERT [dbo].[Orders] ([order_id], [order_date], [client_id], [order_sum]) VALUES (3, CAST(N'2018-01-01T00:00:00.000' AS DateTime), 1, 40);
INSERT [dbo].[Orders] ([order_id], [order_date], [client_id], [order_sum]) VALUES (4, CAST(N'2018-01-01T00:00:00.000' AS DateTime), 2, 40);
INSERT [dbo].[Orders] ([order_id], [order_date], [client_id], [order_sum]) VALUES (5, CAST(N'2018-01-01T00:00:00.000' AS DateTime), 3, 120);
