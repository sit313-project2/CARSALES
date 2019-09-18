using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CarsalesAppAgain.Models;

namespace CarsalesAppAgain.ViewModels
{

    public class CardDataViewModel
    {
        public IList<CardDataModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public CardDataViewModel()
        {
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            // for (var i = 0; i < 10; i++)
            {
                CardDataCollection = new ObservableCollection<CardDataModel>
                {
                    new CardDataModel
                    {
                     HeadTitle = "2016 Land Cruiser 200 ",


                     ProfileImage = "landcruiser.png",
                     HeadLinesDesc = "$100,000",

                    },



                     new CardDataModel
                    {
                     HeadTitle = "2013 Jeep Wrangler Rubicon JK",

                     HeadLinesDesc = "$36,000",

                     ProfileImage = "icon.png"
                     },



                      new CardDataModel
                    {
                    HeadTitle       = "2014 Mercedes-Benz SLS AMG",

                     HeadLinesDesc     = "$430,000",

                      ProfileImage     = "icon.png"
                      },


                       new CardDataModel
                    {
                    HeadTitle = "2017 Lexus LX570",

                     HeadLinesDesc="$250,000",
                     ProfileImage = "icon.png"

                       },


                        new CardDataModel
                    {
                    HeadTitle= "2003 Land Cruiser 100 Sahara",
                   HeadLinesDesc  = "$30,000" ,

                     ProfileImage = "icon.png"
                        },


                         new CardDataModel
                    {
                      HeadTitle = "1997 Land Cruiser VXR80",
                      HeadLinesDesc = "$50,000",

                      ProfileImage = "icon.png"
                         },


                          new CardDataModel
                    {
                     HeadTitle = "2006 Range Rover Vogue 4.2 Supercharger",
                      HeadLinesDesc = "$29,000",

                      ProfileImage = "icon.png"
                          },
                   
                 //   AlertColor =  Color.Green : Color.Blue,    This can be added to set alert dialog inside card data model
                };



            }
        }
    }
}