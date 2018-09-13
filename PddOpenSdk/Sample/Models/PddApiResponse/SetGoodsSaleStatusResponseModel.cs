using System.Collections.Generic;
using Newtonsoft.Json;
namespace App.Models.PddApiResponse
{
    public partial class SetGoodsSaleStatusResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("goods_sale_status_set_response")]
public object GoodsSaleStatusSetResponse {get;set;}
/// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("is_success")]
public bool IsSuccess {get;set;}

    public partial class GoodsSaleStatusSetResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 是否修改成功
/// </summary>
[JsonProperty("is_success")]
public bool IsSuccess {get;set;}

}

}
}
