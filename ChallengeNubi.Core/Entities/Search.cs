using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeNubi.Core.Entities
{
    public partial class Search
    {        
        public string site_id { get; set; }
        public string query { get; set; }
        public Paging paging { get; set; }
        public Result[] results { get; set; }
        public object[] secondary_results { get; set; }
        public object[] related_results { get; set; }
        public Sort sort { get; set; }
        public Available_Sorts[] available_sorts { get; set; }
        public Filter[] filters { get; set; }
        public Available_Filters[] available_filters { get; set; }
        
        public class Paging
        {
            public int total { get; set; }
            public int offset { get; set; }
            public int limit { get; set; }
            public int primary_results { get; set; }
        }

        public class Sort
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Result
        {
            public string id { get; set; }
            public string site_id { get; set; }
            public string title { get; set; }
            public Seller seller { get; set; }
            public float price { get; set; }
            //public string currency_id { get; set; }
            //public int available_quantity { get; set; }
            //public int sold_quantity { get; set; }
            //public string buying_mode { get; set; }
            //public string listing_type_id { get; set; }
            //public DateTime stop_time { get; set; }
            //public string condition { get; set; }
            public string permalink { get; set; }
            //public string thumbnail { get; set; }
            //public bool accepts_mercadopago { get; set; }
            //public Installments installments { get; set; }
            //public Address address { get; set; }
            //public Shipping shipping { get; set; }
            //public Seller_Address seller_address { get; set; }
            //public Attribute[] attributes { get; set; }
            //public Differential_Pricing differential_pricing { get; set; }
            //public object original_price { get; set; }
            //public string category_id { get; set; }
            //public object official_store_id { get; set; }
            //public string catalog_product_id { get; set; }
            //public string[] tags { get; set; }
            //public bool catalog_listing { get; set; }
        }

        public class Seller
        {
            public int id { get; set; }
            //public string permalink { get; set; }
            //public string power_seller_status { get; set; }
            //public bool car_dealer { get; set; }
            //public bool real_estate_agency { get; set; }
            //public object[] tags { get; set; }
            //public Eshop eshop { get; set; }
        }

        public class Eshop
        {
            public int eshop_id { get; set; }
            public int seller { get; set; }
            public string nick_name { get; set; }
            public int eshop_status_id { get; set; }
            public string site_id { get; set; }
            public string eshop_logo_url { get; set; }
            public int eshop_experience { get; set; }
            public object eshop_rubro { get; set; }
            public object[] eshop_locations { get; set; }
        }

        public class Installments
        {
            public int quantity { get; set; }
            public float amount { get; set; }
            public float rate { get; set; }
            public string currency_id { get; set; }
        }

        public class Address
        {
            public string state_id { get; set; }
            public string state_name { get; set; }
            public string city_id { get; set; }
            public string city_name { get; set; }
        }

        public class Shipping
        {
            public bool free_shipping { get; set; }
            public string mode { get; set; }
            public string[] tags { get; set; }
            public string logistic_type { get; set; }
            public bool store_pick_up { get; set; }
        }

        public class Seller_Address
        {
            public string id { get; set; }
            public string comment { get; set; }
            public string address_line { get; set; }
            public string zip_code { get; set; }
            public Country country { get; set; }
            public State state { get; set; }
            public City city { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
        }

        public class Country
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class State
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class City
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Differential_Pricing
        {
            public int id { get; set; }
        }

        public class Attribute
        {
            public string id { get; set; }
            public string value_name { get; set; }
            public object value_struct { get; set; }
            public Value[] values { get; set; }
            public string attribute_group_name { get; set; }
            public string name { get; set; }
            public string value_id { get; set; }
            public string attribute_group_id { get; set; }
            public long source { get; set; }
        }

        public class Value
        {
            public string id { get; set; }
            public string name { get; set; }
            public object _struct { get; set; }
            public long source { get; set; }
        }

        public class Available_Sorts
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Filter
        {
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public Value1[] values { get; set; }
        }

        public class Value1
        {
            public string id { get; set; }
            public string name { get; set; }
            public Path_From_Root[] path_from_root { get; set; }
        }

        public class Path_From_Root
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class Available_Filters
        {
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public Value2[] values { get; set; }
        }

        public class Value2
        {
            public string id { get; set; }
            public string name { get; set; }
            public int results { get; set; }
        }

    }
}
