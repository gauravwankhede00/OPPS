using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        ApiResponse response;
        private readonly StockDBContext _dbContext;
        public StockController(StockDBContext dBContext)
        {
            _dbContext = dBContext;
            response = new ApiResponse();
        }

        [HttpPost("check")]
        public IActionResult Check([FromBody] StockPurchase stockPurchase)
        {
            if(stockPurchase.Id == 0)
            {
                return BadRequest();
            }
            else if (stockPurchase.Id == 1)
            {
                return NotFound();
            }
            return Ok(stockPurchase);
            
        }

        [HttpPost("check1")]
        public ActionResult Check1([FromBody] StockPurchase stockPurchase)
        {
            if (stockPurchase.Id == 0)
            {
                return BadRequest();
            }
            else if (stockPurchase.Id == 1)
            {
                return NotFound();
            }
            return Ok(stockPurchase);
        }

        [HttpPost("check2")]
        public ActionResult<StockPurchase> Check2([FromBody] StockPurchase stockPurchase)
        {
            if (stockPurchase.Id == 0)
            {
                return BadRequest();
            }
            else if (stockPurchase.Id == 1)
            {
                return NotFound();
            }
            return Ok(stockPurchase);
        }

        #region Purchase

        [HttpGet("GetAllPurchase")]
        public ApiResponse GetAllPurchase()
        {
            try
            {
                // var data = _dbContext.StockPurchases.ToList();
                var data = (from purchase in _dbContext.StockPurchase
                            join product in _dbContext.Product on purchase.ProductId equals product.Id
                            orderby purchase.Id descending
                            select new
                            {
                                ProductId = purchase.ProductId,
                                InvoiceAmout = purchase.InvoiceAmout,
                                Quantity = purchase.Quantity,
                                PurchaseId = purchase.Id,
                                InvoiceNumber = purchase.InvoiceNumber,
                                ProductName = product.Name,
                                SupplierName = purchase.SupplierName,
                                PurchaseDate = purchase.PurchaseDate
                            }).ToList();
                response.Data = data;
                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }


        [HttpPost("CreateNewPurchase")]
        public ApiResponse CreateNewPurchase([FromBody] StockPurchase stockPurchase)
        {
            if (!ModelState.IsValid)
            {
                response.Result = false;
                response.Message = "Error";
                return response;
            }
            try
            {

                var data = _dbContext.StockPurchase.Add(stockPurchase);
                _dbContext.SaveChanges();


                var stockExists = _dbContext.Stock.SingleOrDefault(x => x.ProductId == stockPurchase.ProductId);
                if (stockExists == null)
                {
                    Stock stock = new Stock
                    {
                        CreatedDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                        ProductId = stockPurchase.ProductId,
                        Quantity = stockPurchase.Quantity
                    };
                    _dbContext.Stock.Add(stock);

                }
                else
                {
                    stockExists.Quantity += stockPurchase.Quantity;
                    stockExists.LastModifiedDate = DateTime.Now;

                }
                _dbContext.SaveChanges();
                //response.Data = data;
                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }
        #endregion

        #region Sale

        [HttpGet("GetAllSale")]
        public ApiResponse GetAllSale()
        {
            try
            {
                // var data = _dbContext.StockPurchases.ToList();
                var data = (from sale in _dbContext.Sale
                            join product in _dbContext.Product on sale.ProductId equals product.Id
                            orderby sale.Id descending
                            select new
                            {
                                CustomerName =  sale.CustomerName,
                                MobileNo = sale.MobileNo,
                                InvoiceNumber = sale.InvoiceNumber,
                                ProductId = sale.ProductId,
                                Quantity = sale.Quantity,
                                SaleDate = sale.SaleDate,
                                TotalAmount = sale.TotalAmount,
                                SaleId = sale.Id,
                                ProductName = product.Name
                            }).ToList();
                response.Data = data;
                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }


        [HttpPost("CreateNewSale")]
        public ApiResponse CreateNewSale([FromBody] Sale sale)
        {
            if (!ModelState.IsValid)
            {
                response.Result = false;
                response.Message = "Error";
                return response;
            }
            try
            {




                var saleExists = _dbContext.Sale.SingleOrDefault(x => x.InvoiceNumber == sale.InvoiceNumber);
                var stockExists = _dbContext.Stock.SingleOrDefault(x => x.ProductId == sale.ProductId);
                if (saleExists == null && stockExists != null)
                {
                    var data = _dbContext.Sale.Add(sale);
                    _dbContext.SaveChanges();


                    if (stockExists != null)
                    {
                        stockExists.Quantity -= sale.Quantity;
                        stockExists.LastModifiedDate = DateTime.Now;

                    }
                    _dbContext.SaveChanges();
                    response.Result = true;
                    response.Message = "Sale Entry Created ";
                    return response;
                }
                else
                {
                    response.Result = false;
                    response.Message = "Invoice Already Exists";
                    return response;

                }


            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }
        #endregion

        #region Product

        [HttpGet("GetAllProdusts")]
        public ApiResponse GetAllProdusts()
        {
            try
            {
                 var data = _dbContext.Product.ToList();
               
                response.Data = data;
                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }


        [HttpPost("CreateNewProduct")]
        public ApiResponse CreateNewSale([FromBody] WebAPI.Model.Product product)
        {
            if (!ModelState.IsValid)
            {
                response.Result = false;
                response.Message = "Error";
                return response;
            }
            try
            {




                var ProductExists = _dbContext.Product.Where(x => x.Name == product.Name).Any();
               
                if (!ProductExists)
                {
                    var data = _dbContext.Product.Add(product);
                    _dbContext.SaveChanges();
                    response.Result = true;
                    response.Message = "Product Entry Created ";
                    return response;
                }
                else
                {
                    response.Result = false;
                    response.Message = "Product Already Exists";
                    return response;

                }


            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }
        #endregion
        #region Stock

        [HttpGet("GetStocks")]
        public ApiResponse GetStocks()
        {
            try
            {
                var data = (from stock in _dbContext.Stock
                            join product in _dbContext.Product on stock.ProductId equals product.Id
                            orderby stock.Id descending
                            select new
                            {
                                stockId = stock.Id,
                                CreatedDate = stock.CreatedDate,
                                LastModifiedDate = stock.LastModifiedDate,
                                ProductId = stock.ProductId,
                                Quantity = stock.Quantity,
                                ProductName = product.Name
                            }).ToList();
                response.Data = data;
                response.Result = true;

                response.Data = data;
                response.Result = true;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }

        [HttpGet("CheckStockByProductId:")]
        public ApiResponse CheckStockByProductId(int productId)
        {
            try
            {
                var data = _dbContext.Stock.FirstOrDefault(w => w.ProductId == productId);
                if (data != null)
                {
                    response.Data = data.Quantity > 0;
                    response.Result = true;
                    response.Message = "Stock Available";
                }
                else
                {
                    response.Result = false;
                    response.Message = "Stock Not Exists";
                }                   
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Result = false;
            }
            return response;
        }

        #endregion
    }


    public class ApiResponse
    {
        public bool Result { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
