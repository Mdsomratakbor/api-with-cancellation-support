using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace todo_api_with_cancellation_support.Migrations
{
    /// <inheritdoc />
    public partial class DefaultDataAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoItems",
                columns: new[] { "Id", "CreatedDate", "Description", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 4, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2049), "Description for Todo Item #1", "NEW", "Todo Item #1", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2057) },
                    { 2, new DateTime(2025, 1, 3, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2070), "Description for Todo Item #2", "COMPLETED", "Todo Item #2", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2070) },
                    { 3, new DateTime(2025, 1, 2, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2073), "Description for Todo Item #3", "NEW", "Todo Item #3", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2073) },
                    { 4, new DateTime(2025, 1, 1, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2076), "Description for Todo Item #4", "COMPLETED", "Todo Item #4", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2077) },
                    { 5, new DateTime(2024, 12, 31, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2079), "Description for Todo Item #5", "NEW", "Todo Item #5", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2080) },
                    { 6, new DateTime(2024, 12, 30, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2084), "Description for Todo Item #6", "COMPLETED", "Todo Item #6", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2085) },
                    { 7, new DateTime(2024, 12, 29, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2087), "Description for Todo Item #7", "NEW", "Todo Item #7", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2088) },
                    { 8, new DateTime(2024, 12, 28, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2090), "Description for Todo Item #8", "COMPLETED", "Todo Item #8", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2091) },
                    { 9, new DateTime(2024, 12, 27, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2139), "Description for Todo Item #9", "NEW", "Todo Item #9", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2140) },
                    { 10, new DateTime(2024, 12, 26, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2147), "Description for Todo Item #10", "COMPLETED", "Todo Item #10", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2148) },
                    { 11, new DateTime(2024, 12, 25, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2150), "Description for Todo Item #11", "NEW", "Todo Item #11", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2151) },
                    { 12, new DateTime(2024, 12, 24, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2153), "Description for Todo Item #12", "COMPLETED", "Todo Item #12", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2154) },
                    { 13, new DateTime(2024, 12, 23, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2156), "Description for Todo Item #13", "NEW", "Todo Item #13", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2156) },
                    { 14, new DateTime(2024, 12, 22, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2159), "Description for Todo Item #14", "COMPLETED", "Todo Item #14", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2159) },
                    { 15, new DateTime(2024, 12, 21, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2162), "Description for Todo Item #15", "NEW", "Todo Item #15", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2162) },
                    { 16, new DateTime(2024, 12, 20, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2164), "Description for Todo Item #16", "COMPLETED", "Todo Item #16", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2165) },
                    { 17, new DateTime(2024, 12, 19, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2167), "Description for Todo Item #17", "NEW", "Todo Item #17", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2167) },
                    { 18, new DateTime(2024, 12, 18, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2171), "Description for Todo Item #18", "COMPLETED", "Todo Item #18", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2171) },
                    { 19, new DateTime(2024, 12, 17, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2174), "Description for Todo Item #19", "NEW", "Todo Item #19", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2174) },
                    { 20, new DateTime(2024, 12, 16, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2177), "Description for Todo Item #20", "COMPLETED", "Todo Item #20", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2177) },
                    { 21, new DateTime(2024, 12, 15, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2179), "Description for Todo Item #21", "NEW", "Todo Item #21", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2180) },
                    { 22, new DateTime(2024, 12, 14, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2182), "Description for Todo Item #22", "COMPLETED", "Todo Item #22", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2182) },
                    { 23, new DateTime(2024, 12, 13, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2185), "Description for Todo Item #23", "NEW", "Todo Item #23", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2185) },
                    { 24, new DateTime(2024, 12, 12, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2187), "Description for Todo Item #24", "COMPLETED", "Todo Item #24", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2188) },
                    { 25, new DateTime(2024, 12, 11, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2190), "Description for Todo Item #25", "NEW", "Todo Item #25", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2191) },
                    { 26, new DateTime(2024, 12, 10, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2193), "Description for Todo Item #26", "COMPLETED", "Todo Item #26", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2193) },
                    { 27, new DateTime(2024, 12, 9, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2196), "Description for Todo Item #27", "NEW", "Todo Item #27", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2196) },
                    { 28, new DateTime(2024, 12, 8, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2198), "Description for Todo Item #28", "COMPLETED", "Todo Item #28", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2199) },
                    { 29, new DateTime(2024, 12, 7, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2201), "Description for Todo Item #29", "NEW", "Todo Item #29", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2202) },
                    { 30, new DateTime(2024, 12, 6, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2204), "Description for Todo Item #30", "COMPLETED", "Todo Item #30", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2204) },
                    { 31, new DateTime(2024, 12, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2207), "Description for Todo Item #31", "NEW", "Todo Item #31", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2207) },
                    { 32, new DateTime(2024, 12, 4, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2210), "Description for Todo Item #32", "COMPLETED", "Todo Item #32", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2210) },
                    { 33, new DateTime(2024, 12, 3, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2212), "Description for Todo Item #33", "NEW", "Todo Item #33", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2213) },
                    { 34, new DateTime(2024, 12, 2, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2216), "Description for Todo Item #34", "COMPLETED", "Todo Item #34", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2217) },
                    { 35, new DateTime(2024, 12, 1, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2219), "Description for Todo Item #35", "NEW", "Todo Item #35", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2220) },
                    { 36, new DateTime(2024, 11, 30, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2222), "Description for Todo Item #36", "COMPLETED", "Todo Item #36", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2222) },
                    { 37, new DateTime(2024, 11, 29, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2225), "Description for Todo Item #37", "NEW", "Todo Item #37", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2225) },
                    { 38, new DateTime(2024, 11, 28, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2227), "Description for Todo Item #38", "COMPLETED", "Todo Item #38", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2228) },
                    { 39, new DateTime(2024, 11, 27, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2230), "Description for Todo Item #39", "NEW", "Todo Item #39", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2231) },
                    { 40, new DateTime(2024, 11, 26, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2233), "Description for Todo Item #40", "COMPLETED", "Todo Item #40", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2233) },
                    { 41, new DateTime(2024, 11, 25, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2236), "Description for Todo Item #41", "NEW", "Todo Item #41", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2236) },
                    { 42, new DateTime(2024, 11, 24, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2239), "Description for Todo Item #42", "COMPLETED", "Todo Item #42", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2239) },
                    { 43, new DateTime(2024, 11, 23, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2241), "Description for Todo Item #43", "NEW", "Todo Item #43", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2242) },
                    { 44, new DateTime(2024, 11, 22, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2244), "Description for Todo Item #44", "COMPLETED", "Todo Item #44", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2245) },
                    { 45, new DateTime(2024, 11, 21, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2247), "Description for Todo Item #45", "NEW", "Todo Item #45", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2247) },
                    { 46, new DateTime(2024, 11, 20, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2250), "Description for Todo Item #46", "COMPLETED", "Todo Item #46", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2250) },
                    { 47, new DateTime(2024, 11, 19, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2284), "Description for Todo Item #47", "NEW", "Todo Item #47", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2284) },
                    { 48, new DateTime(2024, 11, 18, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2287), "Description for Todo Item #48", "COMPLETED", "Todo Item #48", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2287) },
                    { 49, new DateTime(2024, 11, 17, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2290), "Description for Todo Item #49", "NEW", "Todo Item #49", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2290) },
                    { 50, new DateTime(2024, 11, 16, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2292), "Description for Todo Item #50", "COMPLETED", "Todo Item #50", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2293) },
                    { 51, new DateTime(2024, 11, 15, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2295), "Description for Todo Item #51", "NEW", "Todo Item #51", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2295) },
                    { 52, new DateTime(2024, 11, 14, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2298), "Description for Todo Item #52", "COMPLETED", "Todo Item #52", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2298) },
                    { 53, new DateTime(2024, 11, 13, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2300), "Description for Todo Item #53", "NEW", "Todo Item #53", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2301) },
                    { 54, new DateTime(2024, 11, 12, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2303), "Description for Todo Item #54", "COMPLETED", "Todo Item #54", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2303) },
                    { 55, new DateTime(2024, 11, 11, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2306), "Description for Todo Item #55", "NEW", "Todo Item #55", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2306) },
                    { 56, new DateTime(2024, 11, 10, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2308), "Description for Todo Item #56", "COMPLETED", "Todo Item #56", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2309) },
                    { 57, new DateTime(2024, 11, 9, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2311), "Description for Todo Item #57", "NEW", "Todo Item #57", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2311) },
                    { 58, new DateTime(2024, 11, 8, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2314), "Description for Todo Item #58", "COMPLETED", "Todo Item #58", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2314) },
                    { 59, new DateTime(2024, 11, 7, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2316), "Description for Todo Item #59", "NEW", "Todo Item #59", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2317) },
                    { 60, new DateTime(2024, 11, 6, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2319), "Description for Todo Item #60", "COMPLETED", "Todo Item #60", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2319) },
                    { 61, new DateTime(2024, 11, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2322), "Description for Todo Item #61", "NEW", "Todo Item #61", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2322) },
                    { 62, new DateTime(2024, 11, 4, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2324), "Description for Todo Item #62", "COMPLETED", "Todo Item #62", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2325) },
                    { 63, new DateTime(2024, 11, 3, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2327), "Description for Todo Item #63", "NEW", "Todo Item #63", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2327) },
                    { 64, new DateTime(2024, 11, 2, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2330), "Description for Todo Item #64", "COMPLETED", "Todo Item #64", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2330) },
                    { 65, new DateTime(2024, 11, 1, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2332), "Description for Todo Item #65", "NEW", "Todo Item #65", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2333) },
                    { 66, new DateTime(2024, 10, 31, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2336), "Description for Todo Item #66", "COMPLETED", "Todo Item #66", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2336) },
                    { 67, new DateTime(2024, 10, 30, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2338), "Description for Todo Item #67", "NEW", "Todo Item #67", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2339) },
                    { 68, new DateTime(2024, 10, 29, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2341), "Description for Todo Item #68", "COMPLETED", "Todo Item #68", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2342) },
                    { 69, new DateTime(2024, 10, 28, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2344), "Description for Todo Item #69", "NEW", "Todo Item #69", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2344) },
                    { 70, new DateTime(2024, 10, 27, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2347), "Description for Todo Item #70", "COMPLETED", "Todo Item #70", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2347) },
                    { 71, new DateTime(2024, 10, 26, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2349), "Description for Todo Item #71", "NEW", "Todo Item #71", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2350) },
                    { 72, new DateTime(2024, 10, 25, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2352), "Description for Todo Item #72", "COMPLETED", "Todo Item #72", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2352) },
                    { 73, new DateTime(2024, 10, 24, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2354), "Description for Todo Item #73", "NEW", "Todo Item #73", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2355) },
                    { 74, new DateTime(2024, 10, 23, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2357), "Description for Todo Item #74", "COMPLETED", "Todo Item #74", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2358) },
                    { 75, new DateTime(2024, 10, 22, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2360), "Description for Todo Item #75", "NEW", "Todo Item #75", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2360) },
                    { 76, new DateTime(2024, 10, 21, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2362), "Description for Todo Item #76", "COMPLETED", "Todo Item #76", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2363) },
                    { 77, new DateTime(2024, 10, 20, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2365), "Description for Todo Item #77", "NEW", "Todo Item #77", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2365) },
                    { 78, new DateTime(2024, 10, 19, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2368), "Description for Todo Item #78", "COMPLETED", "Todo Item #78", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2368) },
                    { 79, new DateTime(2024, 10, 18, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2370), "Description for Todo Item #79", "NEW", "Todo Item #79", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2371) },
                    { 80, new DateTime(2024, 10, 17, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2373), "Description for Todo Item #80", "COMPLETED", "Todo Item #80", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2373) },
                    { 81, new DateTime(2024, 10, 16, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2376), "Description for Todo Item #81", "NEW", "Todo Item #81", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2376) },
                    { 82, new DateTime(2024, 10, 15, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2378), "Description for Todo Item #82", "COMPLETED", "Todo Item #82", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2378) },
                    { 83, new DateTime(2024, 10, 14, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2381), "Description for Todo Item #83", "NEW", "Todo Item #83", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2381) },
                    { 84, new DateTime(2024, 10, 13, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2400), "Description for Todo Item #84", "COMPLETED", "Todo Item #84", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2400) },
                    { 85, new DateTime(2024, 10, 12, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2403), "Description for Todo Item #85", "NEW", "Todo Item #85", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2403) },
                    { 86, new DateTime(2024, 10, 11, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2406), "Description for Todo Item #86", "COMPLETED", "Todo Item #86", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2406) },
                    { 87, new DateTime(2024, 10, 10, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2408), "Description for Todo Item #87", "NEW", "Todo Item #87", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2409) },
                    { 88, new DateTime(2024, 10, 9, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2411), "Description for Todo Item #88", "COMPLETED", "Todo Item #88", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2411) },
                    { 89, new DateTime(2024, 10, 8, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2414), "Description for Todo Item #89", "NEW", "Todo Item #89", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2414) },
                    { 90, new DateTime(2024, 10, 7, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2416), "Description for Todo Item #90", "COMPLETED", "Todo Item #90", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2417) },
                    { 91, new DateTime(2024, 10, 6, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2419), "Description for Todo Item #91", "NEW", "Todo Item #91", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2419) },
                    { 92, new DateTime(2024, 10, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2422), "Description for Todo Item #92", "COMPLETED", "Todo Item #92", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2422) },
                    { 93, new DateTime(2024, 10, 4, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2424), "Description for Todo Item #93", "NEW", "Todo Item #93", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2425) },
                    { 94, new DateTime(2024, 10, 3, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2427), "Description for Todo Item #94", "COMPLETED", "Todo Item #94", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2427) },
                    { 95, new DateTime(2024, 10, 2, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2430), "Description for Todo Item #95", "NEW", "Todo Item #95", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2430) },
                    { 96, new DateTime(2024, 10, 1, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2433), "Description for Todo Item #96", "COMPLETED", "Todo Item #96", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2433) },
                    { 97, new DateTime(2024, 9, 30, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2435), "Description for Todo Item #97", "NEW", "Todo Item #97", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2436) },
                    { 98, new DateTime(2024, 9, 29, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2438), "Description for Todo Item #98", "COMPLETED", "Todo Item #98", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2438) },
                    { 99, new DateTime(2024, 9, 28, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2441), "Description for Todo Item #99", "NEW", "Todo Item #99", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2441) },
                    { 100, new DateTime(2024, 9, 27, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2444), "Description for Todo Item #100", "COMPLETED", "Todo Item #100", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2444) },
                    { 101, new DateTime(2024, 9, 26, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2446), "Description for Todo Item #101", "NEW", "Todo Item #101", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2447) },
                    { 102, new DateTime(2024, 9, 25, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2449), "Description for Todo Item #102", "COMPLETED", "Todo Item #102", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2449) },
                    { 103, new DateTime(2024, 9, 24, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2452), "Description for Todo Item #103", "NEW", "Todo Item #103", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2452) },
                    { 104, new DateTime(2024, 9, 23, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2454), "Description for Todo Item #104", "COMPLETED", "Todo Item #104", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2455) },
                    { 105, new DateTime(2024, 9, 22, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2457), "Description for Todo Item #105", "NEW", "Todo Item #105", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2457) },
                    { 106, new DateTime(2024, 9, 21, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2460), "Description for Todo Item #106", "COMPLETED", "Todo Item #106", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2460) },
                    { 107, new DateTime(2024, 9, 20, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2462), "Description for Todo Item #107", "NEW", "Todo Item #107", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2463) },
                    { 108, new DateTime(2024, 9, 19, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2465), "Description for Todo Item #108", "COMPLETED", "Todo Item #108", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2465) },
                    { 109, new DateTime(2024, 9, 18, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2468), "Description for Todo Item #109", "NEW", "Todo Item #109", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2468) },
                    { 110, new DateTime(2024, 9, 17, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2471), "Description for Todo Item #110", "COMPLETED", "Todo Item #110", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2471) },
                    { 111, new DateTime(2024, 9, 16, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2473), "Description for Todo Item #111", "NEW", "Todo Item #111", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2474) },
                    { 112, new DateTime(2024, 9, 15, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2476), "Description for Todo Item #112", "COMPLETED", "Todo Item #112", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2476) },
                    { 113, new DateTime(2024, 9, 14, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2479), "Description for Todo Item #113", "NEW", "Todo Item #113", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2479) },
                    { 114, new DateTime(2024, 9, 13, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2481), "Description for Todo Item #114", "COMPLETED", "Todo Item #114", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2482) },
                    { 115, new DateTime(2024, 9, 12, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2484), "Description for Todo Item #115", "NEW", "Todo Item #115", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2484) },
                    { 116, new DateTime(2024, 9, 11, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2487), "Description for Todo Item #116", "COMPLETED", "Todo Item #116", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2487) },
                    { 117, new DateTime(2024, 9, 10, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2489), "Description for Todo Item #117", "NEW", "Todo Item #117", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2490) },
                    { 118, new DateTime(2024, 9, 9, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2492), "Description for Todo Item #118", "COMPLETED", "Todo Item #118", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2492) },
                    { 119, new DateTime(2024, 9, 8, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2494), "Description for Todo Item #119", "NEW", "Todo Item #119", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2495) },
                    { 120, new DateTime(2024, 9, 7, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2497), "Description for Todo Item #120", "COMPLETED", "Todo Item #120", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2497) },
                    { 121, new DateTime(2024, 9, 6, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2500), "Description for Todo Item #121", "NEW", "Todo Item #121", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2500) },
                    { 122, new DateTime(2024, 9, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2502), "Description for Todo Item #122", "COMPLETED", "Todo Item #122", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2503) },
                    { 123, new DateTime(2024, 9, 4, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2505), "Description for Todo Item #123", "NEW", "Todo Item #123", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2505) },
                    { 124, new DateTime(2024, 9, 3, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2558), "Description for Todo Item #124", "COMPLETED", "Todo Item #124", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2558) },
                    { 125, new DateTime(2024, 9, 2, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2561), "Description for Todo Item #125", "NEW", "Todo Item #125", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2561) },
                    { 126, new DateTime(2024, 9, 1, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2563), "Description for Todo Item #126", "COMPLETED", "Todo Item #126", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2564) },
                    { 127, new DateTime(2024, 8, 31, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2566), "Description for Todo Item #127", "NEW", "Todo Item #127", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2566) },
                    { 128, new DateTime(2024, 8, 30, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2569), "Description for Todo Item #128", "COMPLETED", "Todo Item #128", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2569) },
                    { 129, new DateTime(2024, 8, 29, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2572), "Description for Todo Item #129", "NEW", "Todo Item #129", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2572) },
                    { 130, new DateTime(2024, 8, 28, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2576), "Description for Todo Item #130", "COMPLETED", "Todo Item #130", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2576) },
                    { 131, new DateTime(2024, 8, 27, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2579), "Description for Todo Item #131", "NEW", "Todo Item #131", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2579) },
                    { 132, new DateTime(2024, 8, 26, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2582), "Description for Todo Item #132", "COMPLETED", "Todo Item #132", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2582) },
                    { 133, new DateTime(2024, 8, 25, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2584), "Description for Todo Item #133", "NEW", "Todo Item #133", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2585) },
                    { 134, new DateTime(2024, 8, 24, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2587), "Description for Todo Item #134", "COMPLETED", "Todo Item #134", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2587) },
                    { 135, new DateTime(2024, 8, 23, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2590), "Description for Todo Item #135", "NEW", "Todo Item #135", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2590) },
                    { 136, new DateTime(2024, 8, 22, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2593), "Description for Todo Item #136", "COMPLETED", "Todo Item #136", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2593) },
                    { 137, new DateTime(2024, 8, 21, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2595), "Description for Todo Item #137", "NEW", "Todo Item #137", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2596) },
                    { 138, new DateTime(2024, 8, 20, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2598), "Description for Todo Item #138", "COMPLETED", "Todo Item #138", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2599) },
                    { 139, new DateTime(2024, 8, 19, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2601), "Description for Todo Item #139", "NEW", "Todo Item #139", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2601) },
                    { 140, new DateTime(2024, 8, 18, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2604), "Description for Todo Item #140", "COMPLETED", "Todo Item #140", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2604) },
                    { 141, new DateTime(2024, 8, 17, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2607), "Description for Todo Item #141", "NEW", "Todo Item #141", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2607) },
                    { 142, new DateTime(2024, 8, 16, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2609), "Description for Todo Item #142", "COMPLETED", "Todo Item #142", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2610) },
                    { 143, new DateTime(2024, 8, 15, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2612), "Description for Todo Item #143", "NEW", "Todo Item #143", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2613) },
                    { 144, new DateTime(2024, 8, 14, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2615), "Description for Todo Item #144", "COMPLETED", "Todo Item #144", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2615) },
                    { 145, new DateTime(2024, 8, 13, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2618), "Description for Todo Item #145", "NEW", "Todo Item #145", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2618) },
                    { 146, new DateTime(2024, 8, 12, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2621), "Description for Todo Item #146", "COMPLETED", "Todo Item #146", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2621) },
                    { 147, new DateTime(2024, 8, 11, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2623), "Description for Todo Item #147", "NEW", "Todo Item #147", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2624) },
                    { 148, new DateTime(2024, 8, 10, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2626), "Description for Todo Item #148", "COMPLETED", "Todo Item #148", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2626) },
                    { 149, new DateTime(2024, 8, 9, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2629), "Description for Todo Item #149", "NEW", "Todo Item #149", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2629) },
                    { 150, new DateTime(2024, 8, 8, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2632), "Description for Todo Item #150", "COMPLETED", "Todo Item #150", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2632) },
                    { 151, new DateTime(2024, 8, 7, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2635), "Description for Todo Item #151", "NEW", "Todo Item #151", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2635) },
                    { 152, new DateTime(2024, 8, 6, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2637), "Description for Todo Item #152", "COMPLETED", "Todo Item #152", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2638) },
                    { 153, new DateTime(2024, 8, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2679), "Description for Todo Item #153", "NEW", "Todo Item #153", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2679) },
                    { 154, new DateTime(2024, 8, 4, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2682), "Description for Todo Item #154", "COMPLETED", "Todo Item #154", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2682) },
                    { 155, new DateTime(2024, 8, 3, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2685), "Description for Todo Item #155", "NEW", "Todo Item #155", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2685) },
                    { 156, new DateTime(2024, 8, 2, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2687), "Description for Todo Item #156", "COMPLETED", "Todo Item #156", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2688) },
                    { 157, new DateTime(2024, 8, 1, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2690), "Description for Todo Item #157", "NEW", "Todo Item #157", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2690) },
                    { 158, new DateTime(2024, 7, 31, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2693), "Description for Todo Item #158", "COMPLETED", "Todo Item #158", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2693) },
                    { 159, new DateTime(2024, 7, 30, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2695), "Description for Todo Item #159", "NEW", "Todo Item #159", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2696) },
                    { 160, new DateTime(2024, 7, 29, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2698), "Description for Todo Item #160", "COMPLETED", "Todo Item #160", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2698) },
                    { 161, new DateTime(2024, 7, 28, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2701), "Description for Todo Item #161", "NEW", "Todo Item #161", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2701) },
                    { 162, new DateTime(2024, 7, 27, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2703), "Description for Todo Item #162", "COMPLETED", "Todo Item #162", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2704) },
                    { 163, new DateTime(2024, 7, 26, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2706), "Description for Todo Item #163", "NEW", "Todo Item #163", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2706) },
                    { 164, new DateTime(2024, 7, 25, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2708), "Description for Todo Item #164", "COMPLETED", "Todo Item #164", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2709) },
                    { 165, new DateTime(2024, 7, 24, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2711), "Description for Todo Item #165", "NEW", "Todo Item #165", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2711) },
                    { 166, new DateTime(2024, 7, 23, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2714), "Description for Todo Item #166", "COMPLETED", "Todo Item #166", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2714) },
                    { 167, new DateTime(2024, 7, 22, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2716), "Description for Todo Item #167", "NEW", "Todo Item #167", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2717) },
                    { 168, new DateTime(2024, 7, 21, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2719), "Description for Todo Item #168", "COMPLETED", "Todo Item #168", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2719) },
                    { 169, new DateTime(2024, 7, 20, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2722), "Description for Todo Item #169", "NEW", "Todo Item #169", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2722) },
                    { 170, new DateTime(2024, 7, 19, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2724), "Description for Todo Item #170", "COMPLETED", "Todo Item #170", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2725) },
                    { 171, new DateTime(2024, 7, 18, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2727), "Description for Todo Item #171", "NEW", "Todo Item #171", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2727) },
                    { 172, new DateTime(2024, 7, 17, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2730), "Description for Todo Item #172", "COMPLETED", "Todo Item #172", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2730) },
                    { 173, new DateTime(2024, 7, 16, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2732), "Description for Todo Item #173", "NEW", "Todo Item #173", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2732) },
                    { 174, new DateTime(2024, 7, 15, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2735), "Description for Todo Item #174", "COMPLETED", "Todo Item #174", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2735) },
                    { 175, new DateTime(2024, 7, 14, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2737), "Description for Todo Item #175", "NEW", "Todo Item #175", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2738) },
                    { 176, new DateTime(2024, 7, 13, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2740), "Description for Todo Item #176", "COMPLETED", "Todo Item #176", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2740) },
                    { 177, new DateTime(2024, 7, 12, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2743), "Description for Todo Item #177", "NEW", "Todo Item #177", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2743) },
                    { 178, new DateTime(2024, 7, 11, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2745), "Description for Todo Item #178", "COMPLETED", "Todo Item #178", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2746) },
                    { 179, new DateTime(2024, 7, 10, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2748), "Description for Todo Item #179", "NEW", "Todo Item #179", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2748) },
                    { 180, new DateTime(2024, 7, 9, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2751), "Description for Todo Item #180", "COMPLETED", "Todo Item #180", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2751) },
                    { 181, new DateTime(2024, 7, 8, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2753), "Description for Todo Item #181", "NEW", "Todo Item #181", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2754) },
                    { 182, new DateTime(2024, 7, 7, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2756), "Description for Todo Item #182", "COMPLETED", "Todo Item #182", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2756) },
                    { 183, new DateTime(2024, 7, 6, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2759), "Description for Todo Item #183", "NEW", "Todo Item #183", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2759) },
                    { 184, new DateTime(2024, 7, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2761), "Description for Todo Item #184", "COMPLETED", "Todo Item #184", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2762) },
                    { 185, new DateTime(2024, 7, 4, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2764), "Description for Todo Item #185", "NEW", "Todo Item #185", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2764) },
                    { 186, new DateTime(2024, 7, 3, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2767), "Description for Todo Item #186", "COMPLETED", "Todo Item #186", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2767) },
                    { 187, new DateTime(2024, 7, 2, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2769), "Description for Todo Item #187", "NEW", "Todo Item #187", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2769) },
                    { 188, new DateTime(2024, 7, 1, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2772), "Description for Todo Item #188", "COMPLETED", "Todo Item #188", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2772) },
                    { 189, new DateTime(2024, 6, 30, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2775), "Description for Todo Item #189", "NEW", "Todo Item #189", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2775) },
                    { 190, new DateTime(2024, 6, 29, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2777), "Description for Todo Item #190", "COMPLETED", "Todo Item #190", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2778) },
                    { 191, new DateTime(2024, 6, 28, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2780), "Description for Todo Item #191", "NEW", "Todo Item #191", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2780) },
                    { 192, new DateTime(2024, 6, 27, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2783), "Description for Todo Item #192", "COMPLETED", "Todo Item #192", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2783) },
                    { 193, new DateTime(2024, 6, 26, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2815), "Description for Todo Item #193", "NEW", "Todo Item #193", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2816) },
                    { 194, new DateTime(2024, 6, 25, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2818), "Description for Todo Item #194", "COMPLETED", "Todo Item #194", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2819) },
                    { 195, new DateTime(2024, 6, 24, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2821), "Description for Todo Item #195", "NEW", "Todo Item #195", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2822) },
                    { 196, new DateTime(2024, 6, 23, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2824), "Description for Todo Item #196", "COMPLETED", "Todo Item #196", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2824) },
                    { 197, new DateTime(2024, 6, 22, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2827), "Description for Todo Item #197", "NEW", "Todo Item #197", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2827) },
                    { 198, new DateTime(2024, 6, 21, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2830), "Description for Todo Item #198", "COMPLETED", "Todo Item #198", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2830) },
                    { 199, new DateTime(2024, 6, 20, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2832), "Description for Todo Item #199", "NEW", "Todo Item #199", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2833) },
                    { 200, new DateTime(2024, 6, 19, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2835), "Description for Todo Item #200", "COMPLETED", "Todo Item #200", new DateTime(2025, 1, 5, 12, 24, 41, 373, DateTimeKind.Utc).AddTicks(2836) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ToDoItems",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
