using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBmodel {
    public class trpo {

        public static object getS(int id) {
            var dbContext = new TRPODataContext();
            if (id == 1) {
                return dbContext.scheme1s;
            } else if (id == 2) {
                return dbContext.scheme2s;
            } else if (id == 3) {
                return dbContext.scheme3s;
            } else if (id == 9999) {
                return dbContext.elements;
            }
            return null;
        }

        public static object getData(int id) {
            var dbContext = new TRPODataContext();
            if (id == 0) {
                return dbContext.resistors;
            } else if (id == 1) {
                return dbContext.capasitors;
            } else if (id == 2) {
                return dbContext.coils;
            }
            return null;
        }

        private static List<object> getScheme(TRPODataContext dbContext, Dictionary<int, int> ids) {
            var result = new List<object>();
            for (int i = 0; i < ids.Count; i++) {
                var type = (from elems in dbContext.elements where elems.id == ids.Keys.ToList()[i] select elems.element1).ToArray()[0];
                switch (type) {
                    case "res":
                        var res = (from ress in dbContext.resistors where ress.id == ids.Keys.ToList()[i] select ress).ToArray()[0];
                        for (int j = 0; j < ids.Values.ToList()[i]; j++) 
                            result.Add(res);
                        break;
                    case "cap":
                        var cap = (from ress in dbContext.capasitors where ress.id == ids.Keys.ToList()[i] select ress).ToArray()[0];
                        for (int j = 0; j < ids.Values.ToList()[i]; j++)
                            result.Add(cap);
                        break;
                    case "ind":
                        var ind = (from ress in dbContext.coils where ress.id == ids.Keys.ToList()[i] select ress).ToArray()[0];
                        for (int j = 0; j < ids.Values.ToList()[i]; j++)
                            result.Add(ind);
                        break;
                    default: break;
                }
            }
            return result;
        }

        private static List<object> getScheme1() {
            using (var dbContext = new TRPODataContext()) {
                var dictionary = new Dictionary<int, int>();
                var ids = (from elems in dbContext.scheme1s select elems.id_elem).ToList();
                for (int i = 0; i < ids.Count; i++) {
                    var count = (from elems in dbContext.scheme1s 
                                 where elems.id_elem == ids[i] 
                                 select elems.count).ToList()[0];
                    dictionary.Add(ids[i], count);
                }
                return getScheme(dbContext, dictionary);
            }
        }

        private static List<object> getScheme2() {
            using (var dbContext = new TRPODataContext()) {
                var dictionary = new Dictionary<int, int>();
                var ids = (from elems in dbContext.scheme2s select elems.id_elem).ToList();
                return getScheme(dbContext, dictionary);
            }
        }

        private static List<object> getScheme3() {
            using (var dbContext = new TRPODataContext()) {
                var dictionary = new Dictionary<int, int>();

                return getScheme(dbContext, dictionary);
            }
        }

        public static List<object> getScheme(int schemeInd) {
            using (var dbContext = new TRPODataContext()) {
                switch (schemeInd) {
                    case 1: return getScheme1();
                    case 2: return getScheme2();
                    case 3: return getScheme3();
                    default: return null;
                }
            }
        }

        private static int getLastId(TRPODataContext dbContext) {
            var ids = from elements in dbContext.elements
                      orderby elements.id descending
                      select elements;
            var lastInd = ids.ToList()[0].id;
            return lastInd+1;
        }

        public static void insertElement(resistor res) {
            using (var dbContext = new TRPODataContext()) {
                res.id = getLastId(dbContext);
                dbContext.elements.InsertOnSubmit(new element { id = res.id, element1 = "res" });
                dbContext.resistors.InsertOnSubmit(res);
                dbContext.SubmitChanges();
            }
        }

        public static void insertElement(capasitor cap) {
            using (var dbContext = new TRPODataContext()) {
                cap.id = getLastId(dbContext);
                dbContext.elements.InsertOnSubmit(new element { id = cap.id, element1 = "cap" });
                dbContext.capasitors.InsertOnSubmit(cap);
                dbContext.SubmitChanges();
            }
        }

        public static void insertElement(coil c) {
            using (var dbContext = new TRPODataContext()) {
                c.id = getLastId(dbContext);
                dbContext.elements.InsertOnSubmit(new element { id = c.id, element1 = "ind" });
                dbContext.coils.InsertOnSubmit(c);
                dbContext.SubmitChanges();
            }
        }

        public static void updateElement(resistor res) {
            try {
                using (var dbContext = new TRPODataContext()) {
                    var resistor = dbContext.resistors.SingleOrDefault(x => x.id == res.id);
                    resistor.name = res.name;
                    resistor.max_temp = res.max_temp;
                    resistor.max_voltage = res.max_voltage;
                    resistor.resistance = res.resistance;
                    resistor.price = res.price;
                    dbContext.SubmitChanges();
                }
            } catch {
            }
        }

        public static void updateElement(capasitor res) {
            try {
                using (var dbContext = new TRPODataContext()) {
                    var capasitor = dbContext.capasitors.SingleOrDefault(x => x.id == res.id);
                    capasitor.name = res.name;
                    capasitor.max_temp = res.max_temp;
                    capasitor.max_freq = res.max_freq;
                    capasitor.resistance = res.resistance;
                    capasitor.price = res.price;
                    dbContext.SubmitChanges();
                }
            } catch {
            }
        }

        public static void updateElement(coil c) {
            try {
                using (var dbContext = new TRPODataContext()) {
                    var capasitor = dbContext.coils.SingleOrDefault(x => x.id == c.id);
                    capasitor.name = c.name;
                    capasitor.max_temp = c.max_temp;
                    capasitor.max_freq = c.max_freq;
                    capasitor.industance = c.industance;
                    capasitor.price = c.price;
                    dbContext.SubmitChanges();
                }
            } catch {
            }
        }

        public static void removeElement(resistor res) {
            using (var dbContext = new TRPODataContext()) {
                dbContext.elements.DeleteOnSubmit(new element { id = res.id, element1 = "resistor" });
                dbContext.resistors.DeleteOnSubmit(res);
                dbContext.SubmitChanges();
            }
        }

        public static void removeElement(capasitor cap) {
            using (var dbContext = new TRPODataContext()) {
                dbContext.elements.DeleteOnSubmit(new element { id = cap.id, element1 = "capasitor" });
                dbContext.capasitors.DeleteOnSubmit(cap);
                dbContext.SubmitChanges();
            }
        }

        public static void removeElement(coil c) {
            using (var dbContext = new TRPODataContext()) {
                dbContext.elements.DeleteOnSubmit(new element { id = c.id, element1 = "coil" });
                dbContext.coils.DeleteOnSubmit(c);
                dbContext.SubmitChanges();
            }
        }

        public static IQueryable getElement(int id) {
            var mdc = new TRPODataContext();
            IQueryable query = null;
            if (id == 0) {
                query = from c in mdc.resistors select c;
            } else if (id == 1) {
                query = from c in mdc.capasitors select c;
            } else if (id == 2) {
                query = from c in mdc.coils select c;
            }
            return query;
        }
    }
}
