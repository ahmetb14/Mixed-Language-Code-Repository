package nLayeredDemo.business.concretes;

import java.util.List;

import nLayeredDemo.business.abstracts.ProductService;
import nLayeredDemo.core.LoggerService;
import nLayeredDemo.dataAccess.abstracts.ProductDao;
import nLayeredDemo.entities.concretes.Product;

public class ProductManager implements ProductService {

	private ProductDao productDao;
	private LoggerService loggerService;

	public ProductManager(ProductDao productDao, LoggerService loggerService) {

		super();
		this.productDao = productDao;
		this.loggerService = loggerService;

	}

	@Override
	public void add(Product product) {

		if (product.getCategoryId() == 1) {
			System.out.println("> Bu Kategoride Ürün Kabul Edilemiyor!");
			return;
		}

		this.productDao.add(product);
		this.loggerService.logToSystem("Ürün Eklendi! : " + product.getName());

	}

	@Override
	public List<Product> getAll() {
		return null;
	}

}
