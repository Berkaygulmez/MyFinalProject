import { ResponseModel } from "./responseModel";
import { Category } from "./category";

export interface CategoryResponseModel extends ResponseModel{
    date:Category[]
}