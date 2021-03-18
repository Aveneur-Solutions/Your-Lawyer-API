import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = "http://localhost:5000/api";

axios.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("jwt");
    if (token) config.headers.Authorization = `Bearer ${token}`;
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

const responseBody = (response: AxiosResponse) => response.data;

const request = {
  get: (url: string) => axios.get(url).then(responseBody),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
  del: (url: string) => axios.delete(url).then(responseBody),
  postFile: (url: string, file: Blob) => {
    let formData = new FormData();
    formData.append("File", file);
    return axios
      .post(url, formData, {
        headers: { "Content-type": "multipart/form-data" },
      })
      .then(responseBody);
  },
  postFileToUser: (url: string, userName: string, file: Blob) => {
    let formData = new FormData();
    formData.append("UserName", userName);
    formData.append("File", file);
    return axios
      .post(url, formData, {
        headers: { "Content-type": "multipart/form-data" },
      })
      .then(responseBody);
  },
};

const Lawyer = {
  list: (): Promise<any[]> => request.get("/lawyer"),
};

const User = {
  getUser: (): Promise<any> => request.get("/user"),
};

const Message = {
  fileUpload: (file: Blob) => request.postFile("/file", file),
  fileUploadToUser: (userName: string, file: Blob) =>
    request.postFileToUser("/filex", userName, file),
};

export default { Lawyer, User, Message };
