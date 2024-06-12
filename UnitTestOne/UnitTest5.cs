using XTreeFour;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest5
    {

        [TestMethod]
        public void TestAddRemove1()
        {
            List<int> list = new List<int>() { 1575341253, 280839652, 1522193928, 103352127, 1357819504, 697478386, 1178764944,
            826801813, 411718394, 1897458379, 923951559, 292988519, 411049841, 1619608520, 138849323, 646507990, 2104091918, 1332986233, 
            383722739, 88590940,  1658160836, 1381172724, 727223331, 2107454723, 1145543199, 543571015, 1500283440, 2136982702, 2081414315, 
            951398359, 902756556, 663993657, 953505938, 357420862, 1856685284, 943704444, 1241886552, 38792627, 1059518524, 189474343, 958542360,
            855015568, 367277401, 1818267989, 1515970988, 151341068, 482218110, 231908581, 1652611378, 878004306, 184950462, 1511220806,
            1253004357, 11564369, 25159109, 851651524, 922250806, 305758924, 647156696, 468658119, 1486144779, 1784984300, 1407252309,
            1311517953, 1482719949, 2088959029, 1878014823, 1997615478, 2001719494, 526630467, 802202758, 883875024, 1327534880,
            2036981819, 2089766652, 645993040, 1527565650, 256492896, 1900318577, 321629134, 771517645, 716381273, 627909487,
            1616654229, 630886280, 1353610559, 1964260182, 93742708, 2141086377, 1346575650, 1479717687, 740573073, 403084053,
            1493025278, 453384105, 135499603, 2078929355, 1882746063, 1703185579, 1763794707 };

            var a = new Tree();
            a.AddRange(list);

            var RemoveList = new List<int>();
            int n = list.Count - (list.Count / 5);
            for (int i = 0; i < n; i++)
            {
                RemoveList.Add(list[i]);
            }

            a.RemoveRange(RemoveList);

            Assert.AreEqual(4, a.Height());
            Assert.AreEqual(0, a.GetOverload());
            Assert.AreEqual(20, a.Count());
            Assert.IsTrue(Util.IsSorted(a.ToList()));
            Assert.IsTrue(Math.Abs(a.GetOverload()) <= 2);
            a.Clear();
            list.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestAddRemove2()
        {
            List<int> list = new List<int>() { 1242933071, 1269410557, 1458866125, 1161188560, 1299929474, 184277641, 839910026, 
                1612676426, 313145913, 1804593669, 1015726829, 592961372, 539955661, 615183294, 628325380, 1915236624, 756271722, 
                996252874, 378699232, 587836634, 1030407456, 1141884086, 473257110, 1933700686, 1025383222, 1509668184, 834127898, 
                1049417813, 400458928, 237151404, 27035447, 2060276241, 1228152343, 652929812, 849846663, 1897019352, 31338159, 
                1665494427, 1763709724, 1327517034, 1525781640, 241109881, 1359483661, 557710528, 1126330774, 169631260, 213154812, 
                1919461692, 465435429, 2020029244, 200497489, 1233362114, 866658345, 1911779907, 1788284384, 839103110, 389832710, 
                1457658863, 510333932, 1240698066, 1548414048, 2070983110, 2109501923, 1075363711, 1018473974, 762966916, 1538193850, 
                2038366647, 1640631968, 150409260, 2117252473, 14015032, 1969756175, 1592080611, 1161234971, 212349866, 1052039677, 
                19537970, 685555510, 166961792, 942099204, 1089495247, 699829276, 1347925689, 1400193542, 1192156575, 1484463363, 
                1914356540, 614201859, 654843095, 1115973124, 482236323, 1791366072, 25968218, 471812244, 797622231, 174081332, 
                200723128, 419585665, 165404707 };

            var a = new Tree();
            a.AddRange(list);

            var RemoveList = new List<int>();
            int n = list.Count - (list.Count / 5);
            for (int i = 0; i < n; i++)
            {
                RemoveList.Add(list[i]);
            }

            a.RemoveRange(RemoveList);

            Assert.AreEqual(4, a.Height());
            Assert.AreEqual(0, a.GetOverload());
            Assert.AreEqual(20, a.Count());
            Assert.IsTrue(Util.IsSorted(a.ToList()));
            Assert.IsTrue(Math.Abs(a.GetOverload()) <= 2);
            a.Clear();
            list.Clear();
            Assert.IsNull(a.Root);
        }


        [TestMethod]
        public void TestAddRemove3()
        {
            List<int> list = new List<int>() { 181821190, 454358163, 2104803506, 870022461, 325571758, 1441595158, 2103138102,
                530085296, 1690268386, 1474583647, 1885935194, 308687832, 1487421907, 1433761654, 1484926964, 835916950,
                1905594943, 699820146, 1060815607, 974889233, 1267726200, 277364681, 407541224, 780718611, 279834021, 641564847,
                1316650373, 826909200, 410090933, 241066981, 792282031, 194605228, 1106059302, 407852627, 1154560483, 285664798,
                1834517149, 744489028, 400994284, 178840610, 1326682866, 1443156184, 317611150, 1639843597, 1202051789, 500346766,
                2080044877, 1344865406, 513284465, 412325960, 2121548140, 821468758, 32343635, 1167519735, 1692303015, 454034676,
                1587050596, 1392903704, 558967435, 1848559016, 1718446429, 1192885440, 1985740312, 1684828773, 471916638,
                1018767653, 2119941568, 2086584725, 691377354, 1617290215, 558818680, 1914858141, 923304774, 1974809526,
                1110897752, 26242905, 1446399492, 1320871854, 1926210676, 1455579817, 1517022764, 93783211, 907051511,
                1765218945, 2122395025, 1845201091, 1106287944, 1435335844, 501927087, 2017479665, 1473573355, 1670516561,
                1224565866, 46138590, 225495542, 882499063, 1080188352, 736917228, 2128548376, 466886473 };

            var a = new Tree();
            a.AddRange(list);

            var RemoveList = new List<int>();
            int n = list.Count - (list.Count / 5);
            for (int i = 0; i < n; i++)
            {
                RemoveList.Add(list[i]);
            }

            a.RemoveRange(RemoveList);

            Assert.AreEqual(4, a.Height());
            Assert.AreEqual(0, a.GetOverload());
            Assert.AreEqual(20, a.Count());
            Assert.IsTrue(Util.IsSorted(a.ToList()));
            Assert.IsTrue(Math.Abs(a.GetOverload()) <= 2);
            a.Clear();
            list.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestAddRemove4()
        {
            List<int> list = Util.RandomList(200);

            var a = new Tree();
            a.AddRange(list);

            var RemoveList = new List<int>();
            int n = list.Count - (list.Count / 5);
            for (int i = 0; i < n; i++)
            {
                RemoveList.Add(list[i]);
            }

            a.RemoveRange(RemoveList);

            int height = a.Height();
            Assert.IsTrue(height > 3);
            Assert.IsTrue(height <= 6);
            Assert.IsTrue(Util.IsSorted(a.ToList()));
            Assert.IsTrue(Math.Abs(a.GetOverload()) <= 2);
            a.Clear();
            list.Clear();
            Assert.IsNull(a.Root);
        }


        [TestMethod]
        public void TestAddRemove5()
        {
            List<int> list = Util.RandomList(500);

            var a = new Tree();
            a.AddRange(list);

            var RemoveList = new List<int>();
            int n = list.Count - (list.Count / 5);
            for (int i = 0; i < n; i++)
            {
                RemoveList.Add(list[i]);
            }

            a.RemoveRange(RemoveList);

            int height = a.Height();
            Assert.IsTrue(height > 4);
            Assert.IsTrue(height <= 7);
            Assert.IsTrue(Util.IsSorted(a.ToList()));
            Assert.IsTrue(Math.Abs(a.GetOverload()) <= 2);
            a.Clear();
            list.Clear();
            Assert.IsNull(a.Root);  
        }

        [TestMethod]
        public void TestAddRemove6()
        {
            List<int> list = Util.RandomList(1000);

            var a = new Tree();
            a.AddRange(list);

            var RemoveList = new List<int>();
            int n = list.Count - (list.Count / 5);
            for (int i = 0; i < n; i++)
            {
                RemoveList.Add(list[i]);
            }

            a.RemoveRange(RemoveList);

            int height = a.Height();
            Assert.IsTrue(height > 5);
            Assert.IsTrue(height <= 8);
            Assert.IsTrue(Util.IsSorted(a.ToList()));
            Assert.IsTrue(Math.Abs(a.GetOverload()) <= 2);
            a.Clear();
            list.Clear();
            Assert.IsNull(a.Root);  
        }


    }
}
