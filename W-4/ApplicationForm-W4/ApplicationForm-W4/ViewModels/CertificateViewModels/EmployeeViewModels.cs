using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationForm_W4.Models.CertificateViewModels
{
    public class EmployeeViewModels
    {
        [Key]
        public int emp { get; set; }
        //Current Name
        [Required]
        [StringLength(25, ErrorMessage = "Max 25 characters")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        [StringLength(25, ErrorMessage = "Max 25 characters")]
        [Display(Name = "Middle Name")]
        public String MiddleName { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Max 25 characters")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        //SSN
        [RegularExpression(@"(^\d{3}-?\d{2}-?\d{4}?$)", ErrorMessage = "SSN is Invalid.")]
        [Display(Name = "SSN")]
        public String SSN { get; set; }

        //Address
        [Required(ErrorMessage = "Street Name and number or rural route is required.")]
        [MaxLength(34, ErrorMessage = "Max 30 characters in Street Name")]
        [Display(Name = "Home address (number and street or rural route)")]
        public String StreetNumberAndName { get; set; }

        [Required(ErrorMessage = "City or Town is required"), MaxLength(18, ErrorMessage = "Max 18 Characters")]
        [Display(Name = "City or town")]
        public String City { get; set; }

        // State
        [Required]
        [Display(Name = "State")]
        public USState CState { get; set; }

        //Zipcode 
        [Required(ErrorMessage = "Zip Code is required"), MaxLength(5, ErrorMessage = "Max 5 Digits")
            , RegularExpression(@"(^\d{5}?$)", ErrorMessage = "Postal code is Invalid.")]
        [Display(Name = "ZIP code")]
        public String ZipCode { get; set; }

        //Marital Status
        [Display(Name = "Single")]
        public bool IsSingle { get; set; }

        [Display(Name = "Married")]
        public bool IsMarried { get; set; }

        [Display(Name = " Married, but withhold at higher Single rate")]
        public bool IsSeparate { get; set; }

        [Display(Name = " If your last name differs from that shown on your social security card, check here. You must call 800-772-1213 for a replacement card.")]
        public bool IsDifferent { get; set; }

        [Display(Name = "Total number of allowances you’re claiming")]
        public int Allowances { get; set; }

        [Display(Name = "Additional amount, if any, you want withheld from each paycheck")]
        public int Paycheck { get; set; }

        [Display(Name = "I claim exemption from withholding for 2018, and I certify that I meet both of the following conditions for exemption Last year I had a right to a refund of all federal income tax withheld because I had no tax liability, and This year I expect a refund of all federal income tax withheld because I expect to have no tax liability. If you meet both conditions, write “Exempt” here ")]
         public String Exemption { get; set; }

        [Required]
        [Display(Name = "Enter Date")]
        public DateTime EntryDate { get; set; }

        [Required]
        [Display(Name = "Employer Name and Address")]
        public String EmployerName { get; set; }
        [Required(ErrorMessage = "Street Name and number or rural route is required.")]
        [MaxLength(34, ErrorMessage = "Max 30 characters in Street Name")]
        public String EmployerStreetNumberAndName { get; set; }
        [Required(ErrorMessage = "City or Town is required"), MaxLength(18, ErrorMessage = "Max 18 Characters")]
        public String EmployerCity { get; set; }
        public USState EState { get; set; }
        [Required(ErrorMessage = "Zip Code is required"), MaxLength(5, ErrorMessage = "Max 5 Digits")
            , RegularExpression(@"(^\d{5}?$)", ErrorMessage = "Postal code is Invalid.")]
         public String EZipCode { get; set; }

        [Required(ErrorMessage = "FEIN is required")]
         [Display(Name = "FEIN")]
        public String FEIN { get; set; }

        [Display(Name = "For Yourself?")]
        public bool IsForYourself { get; set; }

        [Display(Name = " File as married filing jointly?")]
        public bool IsJoint { get; set; }

        [Display(Name = " File as  head of household")]
        public bool IsHeadOfHousehold { get; set; }

        [Display(Name = "Enter yes if you are a single, or married filing separately, and have only one job; or married filing jointly, have only one job, and your spouse doesn’t work; or Your wages from a second job or your spouse’s wages (or the total of both) are $1,500 or less. ")]
        public bool IsSingleJob { get; set; }

        [Display(Name = "CHILD TAX CREDIT: </br> If your total income will be less than $69,801 ($101,401 if married filing jointly), enter “4” for each eligible child.;If your total income will be from $69,801 to $175,550 ($101,401 to $339,000 if married filing jointly), enter “2” for each eligible child.; If your total income will be from $175,551 to $200,000 ($339,001 to $400,000 if married filing jointly), enter “1” for each eligible child.; If your total income will be higher than $200,000 ($400,000 if married filing jointly), enter “-0-” ")]
        public int TotalIncome { get; set; }

        [Display(Name = "Credit for other dependents: </br>  If your total income will be less than $69,801 ($101,401 if married filing jointly), enter “1” for each eligible dependent.;  If your total income will be from $69,801 to $175,550 ($101,401 to $339,000 if married filing jointly), enter “1” for every two dependents(for example, “-0 -” for one dependent, “1” if you have two or three dependents, and “2” if you have four dependents).</br>; If your total income will be higher than $175,550 ($339,000 if married filing jointly), enter “-0-”.")]
        public int OtherDependents { get; set; }

        [Display(Name = "Other credits: If you have other credits, enter the amount from that worksheet here.")]
        public int OtherCredits { get; set; }

        [Display(Name = "Add lines given above and enter the total here .")]
        public int AddLines { get; set; }


        [Display(Name = "1. Enter an estimate of your 2018 itemized deductions. These include qualifying home mortgage interest,charitable contributions, state and local taxes(up to $10, 000), and medical expenses in excess of 7.5 % ofyour income.")]
        public int Deductions { get; set; }

        [Display(Name = "2. ENTER: $24, 000 if you’re married filing jointly or qualifying widow(er); $18, 000 if you’re head of household ; $12,000 if you’re single or married filing separately")]
        public int Enter { get; set; }

        [Display(Name = "3. Subtract line 2 from line 1. If zero or less, enter “-0-” .")]
        public int Subtract { get; set; }

        [Display(Name = "4. Enter an estimate of your 2018 adjustments to income and any additional standard deduction for age or blindness ")]
        public int Estimate { get; set; }

        [Display(Name = "5. Add lines 3 and 4 and enter the total .")]
        public int Add { get; set; }

        [Display(Name = "6. Enter an estimate of your 2018 nonwage income (such as dividends or interest)")]
        public int Nowage { get; set; }

        [Display(Name = "7. Subtract line 6 from line 5. If zero, enter “-0-”. If less than zero, enter the amount in parentheses ")]
        public int Result { get; set; }

        [Display(Name = "8. Divide the amount on line 7 by $4,150 and enter the result here. If a negative amount, enter in parentheses.Drop any fraction. ")]
        public int Divide { get; set; }

        [Display(Name = "9.Enter the number from the Personal Allowances Worksheet, ")]
        public int Personal { get; set; }

        [Display(Name = "10. Add lines 8 and 9 and enter the total here. If zero or less, enter “-0-”. If you plan to use the Two-Earners/Multiple Jobs Worksheet, also enter this total on line 1, page 4.Otherwise, stop here and enter this total on Form W - 4, line 5, page 1")]
        public int Sum { get; set; }

        public enum USState
        {
            //Might have to Add AA and AE
            [Description("Alaska")]
            AK,
            [Description("Alabama")]
            AL,

            [Description("Arkansas")]
            AR,

            [Description("Arizona")]
            AZ,

            [Description("California")]
            CA,

            [Description("Colorado")]
            CO,

            [Description("Connecticut")]
            CT,

            [Description("D.C.")]
            DC,

            [Description("Delaware")]
            DE,

            [Description("Florida")]
            FL,

            [Description("Georgia")]
            GA,

            [Description("Hawaii")]
            HI,

            [Description("Iowa")]
            IA,

            [Description("Idaho")]
            ID,

            [Description("Illinois")]
            IL,

            [Description("Indiana")]
            IN,

            [Description("Kansas")]
            KS,

            [Description("Kentucky")]
            KY,

            [System.ComponentModel.Description("Louisiana")]
            LA,

            [Description("Massachusetts")]
            MA,

            [Description("Maryland")]
            MD,

            [Description("Maine")]
            ME,

            [Description("Michigan")]
            MI,

            [Description("Minnesota")]
            MN,

            [Description("Missouri")]
            MO,

            [Description("Mississippi")]
            MS,

            [Description("Montana")]
            MT,

            [Description("North Carolina")]
            NC,

            [Description("North Dakota")]
            ND,

            [Description("Nebraska")]
            NE,

            [Description("New Hampshire")]
            NH,

            [Description("New Jersey")]
            NJ,

            [Description("New Mexico")]
            NM,

            [Description("Nevada")]
            NV,

            [Description("New York")]
            NY,

            [Description("Oklahoma")]
            OK,

            [Description("Ohio")]
            OH,

            [Description("Oregon")]
            OR,

            [Description("Pennsylvania")]
            PA,

            [Description("Rhode Island")]
            RI,

            [Description("South Carolina")]
            SC,

            [Description("South Dakota")]
            SD,

            [Description("Tennessee")]
            TN,

            [Description("Texas")]
            TX,

            [Description("Utah")]
            UT,

            [Description("Virginia")]
            VA,

            [Description("Vermont")]
            VT,

            [Description("Washington")]
            WA,

            [Description("Wisconsin")]
            WI,

            [Description("West Virginia")]
            WV,

            [Description("Wyoming")]
            WY

        }

        

    }
}
