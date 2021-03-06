﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WebMaze.DbStuff.Model;
using WebMaze.Services;

namespace WebMaze.DbStuff
{
    public class TestDataSeeder
    {
        private UserService userService;

        public TestDataSeeder(IServiceScope scope)
        {
            userService = scope.ServiceProvider.GetService<UserService>();

            if (userService == null)
            {
                throw new Exception("Cannot get UserService from ServiceProvider.");
            }
        }

        public void SeedData()
        {
            AddDoctors();
            AddPolicemen();
            AddRegularUsers();
        }

        private void AddDoctors()
        {
            var doctors = new List<CitizenUser>()
            {
                new CitizenUser
                {
                    Login = "Tsoi",
                    Password = "123",
                    Balance = 300000,
                    RegistrationDate = new DateTime(2020, 10, 28),
                    LastLoginDate = new DateTime(2020, 10, 28),
                    FirstName = "Alexey",
                    LastName = "Tsoi",
                    Gender = "Male",
                    Email = "AlexeyTsoi@example.com",
                    PhoneNumber = "3333333333",
                    BirthDate = new DateTime(1977, 4, 2)
                }
            };
            AddIfNotExistUsersWithRole(doctors, "Doctor");
        }

        private void AddPolicemen()
        {
            var policemen = new List<CitizenUser>()
            {
                new CitizenUser
                {
                    Login = "Chuck",
                    Password = "123",
                    Balance = 6000000,
                    RegistrationDate = new DateTime(2020, 12, 30),
                    LastLoginDate = new DateTime(2020, 12, 30),
                    FirstName = "Chuck",
                    LastName = "Norris",
                    Gender = "Male",
                    Email = "ChuckNorris@example.com",
                    PhoneNumber = "4444444444",
                    BirthDate = new DateTime(1940, 3, 10)
                }
            };
            AddIfNotExistUsersWithRole(policemen, "Policeman");
        }

        private void AddRegularUsers()
        {
            var regularUsers = new List<CitizenUser>()
            {
                new CitizenUser
                {
                    Login = "Ivan",
                    Password = "123",
                    Balance = 1000,
                    RegistrationDate = new DateTime(2021, 1, 12),
                    LastLoginDate = new DateTime(2021, 1, 12),
                    FirstName = "Ivan",
                    LastName = "Sokolov",
                    Gender = "Male",
                    Email = "IvanSokolov@example.com",
                    PhoneNumber = "5555555555",
                    BirthDate = new DateTime(1980, 5, 17)
                },
                new CitizenUser
                {
                    Login = "Anastasia",
                    Password = "123",
                    Balance = 30000,
                    RegistrationDate = new DateTime(2021, 1, 15),
                    LastLoginDate = new DateTime(2021, 1, 15),
                    FirstName = "Anastasia",
                    LastName = "Kuznecova",
                    Gender = "Female",
                    Email = "AnastasiaKuznecova@example.com",
                    PhoneNumber = "66666666",
                    BirthDate = new DateTime(1990, 11, 22)
                },
                new CitizenUser
                {
                    Login = "Arnold",
                    Password = "123",
                    Balance = 0,
                    RegistrationDate = new DateTime(2021, 1, 16),
                    LastLoginDate = new DateTime(2021, 1, 16),
                    FirstName = "Arnold",
                    LastName = "Goldenberg",
                    Gender = "Male",
                    Email = "ArnoldGoldenberg@example.com",
                    PhoneNumber = "77777777",
                    BirthDate = new DateTime(1977, 5, 10)
                },
                new CitizenUser
                {
                    Login = "Aigerim",
                    Password = "123",
                    Balance = 8000,
                    RegistrationDate = new DateTime(2021, 1, 17),
                    LastLoginDate = new DateTime(2021, 1, 17),
                    FirstName = "Aigerim",
                    LastName = "Alieva",
                    Gender = "Female",
                    Email = "AigerimAlieva@example.com",
                    PhoneNumber = "8888888888",
                    BirthDate = new DateTime(1983, 8, 3)
                },
                new CitizenUser
                {
                    Login = "Dias",
                    Password = "123",
                    Balance = 15000,
                    RegistrationDate = new DateTime(2021, 1, 19),
                    LastLoginDate = new DateTime(2021, 1, 19),
                    FirstName = "Dias",
                    LastName = "Karimov",
                    Gender = "Male",
                    Email = "DiasKarimov@example.com",
                    PhoneNumber = "9999999999",
                    BirthDate = new DateTime(2005, 10, 5)
                }
            };

            AddIfNotExistUsersWithRole(regularUsers);
        }

        private void AddIfNotExistUsersWithRole(List<CitizenUser> users, string roleName = null)
        {
            foreach (var user in users)
            {
                var userFromDb = userService.FindByLogin(user.Login);

                if (userFromDb == null)
                {
                    userService.Save(user);
                    if (roleName != null)
                    {
                        userService.AddToRole(user, roleName);
                    }
                }
            }
        }
    }
}

