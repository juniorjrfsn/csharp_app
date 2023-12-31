﻿using System;
using System.Collections.Generic;


namespace Model_Service_Repository.Models
{
    public class GioId
    {
        private static long _epoch = 1644969600;
        private static readonly Dictionary<int, int> _workers = new Dictionary<int, int>
        {
            {0, 0},  {1, 0},  {2, 0},  {3, 0},  {4, 0},  {5, 0},  {6, 0},  {7, 0},  {8, 0},  {9, 0},  {10, 0},
            {11, 0}, {12, 0}, {13, 0}, {14, 0}, {15, 0}, {16, 0}, {17, 0}, {18, 0}, {19, 0}, {20, 0}, {21, 0},
            {22, 0}, {23, 0}, {24, 0}, {25, 0}, {26, 0}, {27, 0}, {28, 0}, {29, 0}, {30, 0}, {31, 0}
        };
        private static readonly Random _random = new Random();

        /// <summary>
        /// generates a unique id.
        /// 2^52 unique ids per second
        /// </summary>
        /// <returns>a unique, unsigned 64-bit integer id</returns>
        public static int New()
        {
            int timeNow = (int)(DateTime.Now - DateTime.UnixEpoch).TotalSeconds;
            int id = (int)(timeNow - _epoch);
            id <<= 5;

            // worker id
            int workerId = _random.Next(0, 32);
            id += workerId;

            // increment
            id += _workers[workerId] % 4096;
            _workers[workerId]++;

            return id;
        }

        /// <summary>
        /// return a creation DateTime object for an id
        /// </summary>
        /// <param name="id">the id generated by the system.</param>
        /// <returns>DateTime object of the Id's creation time</returns>
        public static DateTime GetCreationDate(int id)
        {
            long time = (id >> 5) + _epoch;
            return DateTime.UnixEpoch.AddSeconds(time);
        }
    }
}