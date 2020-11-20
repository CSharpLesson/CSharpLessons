xato
var documentTabs = (await _productTabDocumentService.FindAsync(s => s.DocumentId == documentId)).ToList();

                
                    foreach (var tab in documentTabs)
                    {
                        var lastPrice = _productService.GetLastPrice(CompanyId, document.WarehouseId, tab.ProductId, tab.Barcode);// hech qachon bazadan malumot olib unga o'zgartirish qilib va boshqa boshqa tableni update yoki add yoki delete qilib bo'midi unda ozgatririlgan tablitsani ha saxranit qiladi bunaqa bo'masligi uchun uni huddi shuni yengi modeliga olib qilish kere
                        if (lastPrice != null)
                        {
                            tab.Price = lastPrice.IncomePrice;
                            if (!confirm) //confirm otmenit qilinganda sotilish narx oldingi dkumentdagi narx belgilanadi
                            tab.SellPrice = lastPrice.SellPrice;
                        }
                        _productService.UpdateLastPrice(tab.ProductId, tab.Price, tab.SellPrice);
                        _productBalanceService.UpdatePrice(CompanyId, document.WarehouseId, tab);
                    }
